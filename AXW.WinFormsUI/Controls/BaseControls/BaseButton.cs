using AXW.WinFormsUI.Common;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace AXW.WinFormsUI.Controls.BaseControls
{
    [ToolboxItem(false)]
    public abstract class BaseButton : System.Windows.Forms.Button
    {
        [Browsable(false)]
        public bool IsMousePressed { get; private set; }

        [Browsable(false)]
        public bool IsMouseOver { get; private set; }

        [DefaultValue(typeof(Cursor), "Hand")]
        public override Cursor Cursor { get => base.Cursor; set => base.Cursor = value; }

        [DefaultValue(typeof(Font), "Segoe UI")]
        public override Font Font { get => base.Font; set => base.Font = value; }

        public BaseButton()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.UserPaint |
                //ControlStyles.Opaque |
                ControlStyles.Selectable,
                true);
            DoubleBuffered = true;

            Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            Cursor = Cursors.Hand;
            Size = new Size(110, 30);
        }

        internal virtual StringFormat CreateStringFormat()
        {
            StringFormat format = ControlHelper.StringFormatForAlignment(TextAlign);

            if (RightToLeft == RightToLeft.Yes)
            {
                format.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
            }

            if (AutoEllipsis)
            {
                format.Trimming = StringTrimming.EllipsisCharacter;
                format.FormatFlags |= StringFormatFlags.LineLimit;
            }

            if (!UseMnemonic)
            {
                format.HotkeyPrefix = HotkeyPrefix.None;
            }
            else if (ShowKeyboardCues)
            {
                format.HotkeyPrefix = HotkeyPrefix.Show;
            }
            else
            {
                format.HotkeyPrefix = HotkeyPrefix.Hide;
            }

            if (AutoSize)
            {
                format.FormatFlags |= StringFormatFlags.MeasureTrailingSpaces;
            }
            return format;
        }

        internal virtual TextFormatFlags CreateTextFormatFlags()
        {
            TextAlign = RtlTranslateContent(TextAlign);
            TextFormatFlags flags = ControlHelper.TextFormatFlagsForAlignmentGDI(TextAlign) | (TextFormatFlags.TextBoxControl | TextFormatFlags.WordBreak);
            if (AutoEllipsis)
            {
                flags |= TextFormatFlags.EndEllipsis;
            }
            if (RightToLeft == RightToLeft.Yes)
            {
                flags |= TextFormatFlags.RightToLeft;
            }
            if (!UseMnemonic)
            {
                return (flags | TextFormatFlags.NoPrefix);
            }
            if (!ShowKeyboardCues)
            {
                flags |= TextFormatFlags.HidePrefix;
            }
            return flags;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            IsMouseOver = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            IsMouseOver = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);

            IsMousePressed = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);

            IsMousePressed = false;
            Invalidate();
        }

        protected override void OnKeyDown(KeyEventArgs kevent)
        {
            base.OnKeyDown(kevent);

            if (kevent.KeyCode == Keys.Space)
            {
                IsMousePressed = true;
                Invalidate();
            }
        }

        protected override void OnKeyUp(KeyEventArgs kevent)
        {
            base.OnKeyUp(kevent);

            if (kevent.KeyCode == Keys.Space)
            {
                IsMousePressed = false;
                Invalidate();
            }
        }
    }
}
