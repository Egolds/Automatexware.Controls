using AXW.WinFormsUI.Common;
using AXW.WinFormsUI.Controls.BaseControls;
using AXW.WinFormsUI.Controls.MultiProperties;
using AXW.WinFormsUI.Controls.MultiProperties.ControlDesigners;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 
TODO:
BorderRadius                    +++
AutoColorsGeneration
TextAligment                    +++
TextOffset
Images (Left, Right) / Aligment
ImageOffset

AllowForAllButtonStates
 
 */

namespace AXW.WinFormsUI.Controls
{
    [ToolboxItem(true), Designer(typeof(ButtonDesigner))]
    public class Button : BaseButton
    {
        #region Properties

        [Category("AXW"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ButtonMouseState OnIdleState
        {
            get => onIdleState;
            set
            {
                onIdleState = value;
                Refresh();
            }
        }

        [Category("AXW"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ButtonMouseState OnHoverState
        {
            get => onHoverState;
            set
            {
                onHoverState = value;
                Refresh();
            }
        }

        [Category("AXW"), Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ButtonMouseState OnPressedState
        {
            get => onPressedState;
            set
            {
                onPressedState = value;
                Refresh();
            }
        }

        [Category("AXW")]
        [DefaultValue(true)]
        public bool BorderVisible
        {
            get => borderVisible; set
            {
                borderVisible = value;
                Refresh();
            }
        }

        [Category("AXW")]
        [DefaultValue(1)]
        public int BorderRadius
        {
            get => borderRadius; set
            {
                if (value > 0 && value <= 100)
                {
                    borderRadius = value;
                    Refresh();
                }
                Refresh();
            }
        }

        [Category("AXW")]
        [DefaultValue(false)]
        public bool MakeTransparentCorners
        {
            get => makeTransparentCorners; set
            {
                makeTransparentCorners = value;
                Region = null;
                Refresh();
            }
        }

        [Category("AXW")]
        [DefaultValue(false)]
        public bool FocusVisible
        {
            get => focusVisible; set
            {
                focusVisible = value;
                Refresh();
            }
        }

        [Category("AXW")]
        public Color FocusColor
        {
            get => focusColor; set
            {
                focusColor = value;
                Refresh();
            }
        }

        [Category("AXW")]
        public Color GeneralStatesColor
        {
            get => generalStatesColor; set
            {
                generalStatesColor = value;
                Refresh();
            }
        }

        [Category("AXW")]
        [DefaultValue(false)]
        public bool GeneralStatesColorEnabled
        {
            get => generalStatesColorEnabled; set
            {
                generalStatesColorEnabled = value;
                Refresh();
            }
        }

        #endregion

        #region Obsolete Properties

        [Obsolete("Используйте свойство OnIdleState.BackColor")]
        public override Color BackColor { get => OnIdleState.BackColor; set => OnIdleState.BackColor = value; }

        [Obsolete("Используйте свойство OnIdleState.FontColor")]
        public override Color ForeColor { get => OnIdleState.FontColor; set => OnIdleState.FontColor = value; }

        #endregion

        #region Enums



        #endregion

        #region Private Fields

        private bool borderVisible = true;
        private ButtonMouseState onHoverState;
        private ButtonMouseState onPressedState;
        private ButtonMouseState onIdleState;
        private bool focusVisible;
        private Color focusColor;
        private int borderRadius;
        private bool makeTransparentCorners;
        private Color generalStatesColor = FlatColors.Purple;
        private bool generalStatesColorEnabled;

        #endregion

        public Button()
        {
            onHoverState = new ButtonMouseState(this)
            {
                BackColor = Color.Silver,
                BorderColor = Color.DarkGray,
                FontColor = Color.Black
            };

            onPressedState = new ButtonMouseState(this)
            {
                BackColor = Color.DarkGray,
                BorderColor = Color.DarkGray,
                FontColor = Color.Black
            };

            onIdleState = new ButtonMouseState(this)
            {
                BackColor = Color.Gainsboro,
                BorderColor = Color.DarkGray,
                FontColor = Color.Black
            };

            focusColor = Color.LightSkyBlue;
            borderRadius = 1;
            FlatStyle = FlatStyle.Flat;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Graphics graph = pevent.Graphics;

            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //graph.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graph.Clear(Parent.BackColor);

            RectangleF btnRectange = new RectangleF(0, 0, Width - 1, Height - 1);
            Rectangle btnTextRectangale = new Rectangle(2, 2, Width - 3, Height - 3);
            RectangleF btnFocusRectange = RectangleF.Inflate(btnRectange, -1, -1); // new RectangleF(1, 1, btnRectange.Width - 2, btnRectange.Height - 2);

            Color backColor = GetBackColor();
            Color foreColor = GetForeColor();
            Pen borderPen = GetBorderPen();
            SolidBrush backBrush = new SolidBrush(backColor);

            var borderRadiusSize = Height / 100F * BorderRadius;

            GraphicsPath btnPath = DrawHelper.GetRoundedRectangleF(btnRectange, borderRadiusSize);
            GraphicsPath btnFocusPath = DrawHelper.GetRoundedRectangleF(btnFocusRectange, borderRadiusSize);

            if (MakeTransparentCorners == true)
            {
                RectangleF outRectangeF = RectangleF.Inflate(btnRectange, 0.65F, 0.65F);
                GraphicsPath outPath = DrawHelper.GetRoundedRectangleF(outRectangeF, borderRadiusSize);
                Region = new Region(outPath);
                outPath.Dispose();
            }

            #region Draw Button

            graph.FillPath(backBrush, btnPath);
            if (FocusVisible == true && Focused == true && IsMouseOver == false)
            {
                graph.DrawPath(borderPen, btnFocusPath);
            }
            graph.DrawPath(borderPen, btnPath);

            #endregion

            #region Draw Text

            if (UseCompatibleTextRendering == true)
            {
                var stringFormat = CreateStringFormat();
                graph.DrawString(Text, Font, new SolidBrush(foreColor), btnTextRectangale, stringFormat);
            }
            else
            {
                var textFormatFlags = CreateTextFormatFlags();
                TextRenderer.DrawText(graph, Text, Font, btnTextRectangale, foreColor, textFormatFlags);
            }

            #endregion

            btnPath.Dispose();
            btnFocusPath.Dispose();
            borderPen.Dispose();
            backBrush.Dispose();
        }

        #region Private Methods

        private Color GetBackColor()
        {
            Color backColor = OnIdleState.BackColor;
            if (Enabled == false)
            {
                backColor = Color.FromArgb(150, OnIdleState.BackColor);
            }
            else
            {
                if (IsMouseOver == true)
                {
                    backColor = OnHoverState.BackColor;
                }

                if (IsMousePressed == true)
                {
                    backColor = OnPressedState.BackColor;
                }
            }

            return backColor;
        }

        private Color GetBorderColor()
        {
            Color color = OnIdleState.BorderColor;

            if (BorderVisible == false)
            {
                return GetBackColor();
            }

            if (Enabled == false)
            {
                color = Color.FromArgb(150, OnIdleState.BorderColor);
            }
            else
            {
                if (IsMouseOver == true)
                {
                    color = OnHoverState.BorderColor;
                }

                if (IsMousePressed == true)
                {
                    color = OnPressedState.BorderColor;
                }
            }

            return color;
        }

        private Color GetForeColor()
        {
            Color color = OnIdleState.FontColor;

            if (Enabled == false)
            {
                color = Color.FromArgb(100, OnIdleState.FontColor);
            }
            else
            {
                if (IsMouseOver == true)
                {
                    color = OnHoverState.FontColor;
                }

                if (IsMousePressed == true)
                {
                    color = OnPressedState.FontColor;
                }
            }

            return color;
        }

        private Pen GetBorderPen()
        {
            Pen borderPen = null;

            if (FocusVisible == true && Focused == true && Enabled == true)
            {
                borderPen = new Pen(FocusColor);
                //borderPen.Width = IsMouseOver ? 1 : 2;
            }
            else
            {
                borderPen = new Pen(GetBorderColor());
            }

            return borderPen;
        }

        #endregion

        #region Events



        #endregion
    }
}
