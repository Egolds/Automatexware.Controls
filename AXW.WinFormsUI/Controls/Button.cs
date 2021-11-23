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
BorderRadius
AutoColorsGeneration
TextAligment
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

        [Category("AXW")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        //[RefreshProperties(RefreshProperties.All)]
        public ButtonMouseState OnIdleState
        {
            get => onIdleState;
            set
            {
                onIdleState = value;
                Refresh();
            }
        }

        [Category("AXW")]
        public ButtonMouseState OnHoverState
        {
            get => onHoverState;
            set
            {
                onHoverState = value;
                Refresh();
            }
        }

        [Category("AXW")]
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

        private StringFormat stringFormat = new StringFormat()
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };
        private bool borderVisible = true;
        private ButtonMouseState onHoverState;
        private ButtonMouseState onPressedState;
        private ButtonMouseState onIdleState;
        private bool focusVisible;
        private Color focusColor;

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

            FocusColor = Color.LightSkyBlue;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Graphics graph = pevent.Graphics;

            graph.SmoothingMode = SmoothingMode.HighQuality;
            graph.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graph.Clear(Parent.BackColor);

            Rectangle btnRectange = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle btnFocusRectange = new Rectangle(1, 1, btnRectange.Width - 2, btnRectange.Height - 2);

            Color backColor = GetBackColor();
            Color borderColor = GetBorderColor();
            Color foreColor = GetForeColor();

            // Основной прямоугольник (Фон)
            graph.DrawRectangle(new Pen(borderColor), btnRectange);
            graph.FillRectangle(new SolidBrush(backColor), btnRectange);

            if (FocusVisible == true && Focused == true)
            {
                graph.DrawRectangle(new Pen(FocusColor), btnFocusRectange);
            }

            graph.SetClip(btnRectange);

            graph.DrawString(Text, Font, new SolidBrush(foreColor), btnRectange, stringFormat);
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
                color = Color.FromArgb(150, OnIdleState.FontColor);
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



        #endregion
    }
}
