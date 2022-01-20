using AXW.WinFormsUI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AXW.WinFormsUI.Tester
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            //button1.GotFocus += Button1_GotFocus;
            //button1.LostFocus += Button1_LostFocus;

            //button2.GotFocus += Button1_GotFocus;
            //button2.LostFocus += Button1_LostFocus;

            //button3.GotFocus += Button1_GotFocus;
            //button3.LostFocus += Button1_LostFocus;

            //this.FormBorderStyle = FormBorderStyle.None;
            //this.DoubleBuffered = true;
            //this.SetStyle(ControlStyles.ResizeRedraw, true);

            //var designSize = this.ClientSize;
            //this.FormBorderStyle = FormBorderStyle.Sizable;
            //this.Size = designSize;
        }

        private void Button1_LostFocus(object sender, EventArgs e)
        {
            ((Button)sender).Text = "Нет фокуса";
        }

        private void Button1_GotFocus(object sender, EventArgs e)
        {
            ((Button)sender).Text = "Есть фокус";
        }

        //private const int cGrip = 16;      // Grip size
        //private const int cCaption = 32;   // Caption bar height;
        private const int WM_NCHITTEST = 0x0084;
        private const int HTCLIENT = 1;
        private const int HTCAPTION = 2;

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    //Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
        //    //ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
        //    //rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
        //    //e.Graphics.FillRectangle(Brushes.DarkBlue, rc);

        //    //e.Graphics.FillRectangle(Brushes.Green, Top);
        //    //e.Graphics.FillRectangle(Brushes.Green, Left);
        //    //e.Graphics.FillRectangle(Brushes.Green, Right);
        //    //e.Graphics.FillRectangle(Brushes.Green, Bottom);
        //}

        private const int
    HTLEFT = 10,
    HTRIGHT = 11,
    HTTOP = 12,
    HTTOPLEFT = 13,
    HTTOPRIGHT = 14,
    HTBOTTOM = 15,
    HTBOTTOMLEFT = 16,
    HTBOTTOMRIGHT = 17;

        const int _ = 10; // you can rename this variable if you like

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }

        int c = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            c++;
            //button2.Text = c.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.OnIdleState.BackColor = Color.Tomato;
            button1.BackColor = Color.Tomato;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.OnIdleState.BackColor = FlatColors.Green;

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }

        //protected override void WndProc(ref Message m)
        //{
        //    //base.WndProc(ref m);
        //    //switch (m.Msg)
        //    //{
        //    //    case WM_NCHITTEST:
        //    //        if (m.Result == (IntPtr)HTCLIENT)
        //    //        {
        //    //            m.Result = (IntPtr)HTCAPTION;
        //    //        }
        //    //        break;
        //    //}

        //    //const int wmNcHitTest = 0x84;
        //    //const int htBottomLeft = 16;
        //    //const int htBottomRight = 17;
        //    //if (m.Msg == wmNcHitTest)
        //    //{
        //    //    int x = (int)(m.LParam.ToInt64() & 0xFFFF);
        //    //    int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
        //    //    Point pt = PointToClient(new Point(x, y));
        //    //    Size clientSize = ClientSize;
        //    //    if (pt.X >= clientSize.Width - 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
        //    //    {
        //    //        m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);
        //    //        return;
        //    //    }
        //    //}
        //    //base.WndProc(ref m);

        //    //const int WM_NCCALCSIZE = 0x83;
        //    //if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
        //    //{
        //    //    m.Result = new IntPtr(0xF0);   // Align client area to all borders
        //    //    return;
        //    //}
        //    //base.WndProc(ref m);
        //}

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.Style |= 0x40000;
        //        return cp;
        //    }
        //}

        //protected override void WndProc(ref Message message)
        //{
        //    base.WndProc(ref message);

        //    if (message.Msg == 0x84) // WM_NCHITTEST
        //    {
        //        var cursor = this.PointToClient(Cursor.Position);

        //        if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
        //        else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
        //        else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
        //        else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

        //        else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
        //        else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
        //        else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
        //        else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
        //    }
        //}

        //protected override void WndProc(ref Message m)
        //{
        //    if (m.Msg == 0x84)
        //    {  // Trap WM_NCHITTEST
        //        Point pos = new Point(m.LParam.ToInt32());
        //        pos = this.PointToClient(pos);
        //        if (pos.Y < cCaption)
        //        {
        //            m.Result = (IntPtr)2;  // HTCAPTION
        //            return;
        //        }
        //        if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
        //        {
        //            m.Result = (IntPtr)17; // HTBOTTOMRIGHT
        //            return;
        //        }
        //    }
        //    base.WndProc(ref m);
        //}

    }
}
