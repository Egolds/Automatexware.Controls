using System;
using System.ComponentModel;
using System.Drawing;
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
    }
}
