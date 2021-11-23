using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AXW.WinFormsUI.Controls.BaseControls
{
    internal class BaseCustomControl : Control
    {
        public BaseCustomControl()
        {
            // Understanding the SetStyle Method:
            // https://www.c-sharpcorner.com/UploadFile/dbeniwal321/understanding-the-setstyle-method-in-gdi/

            SetStyle(
                ControlStyles.AllPaintingInWmPaint | 
                ControlStyles.OptimizedDoubleBuffer | 
                ControlStyles.ResizeRedraw | 
                ControlStyles.SupportsTransparentBackColor | 
                ControlStyles.UserPaint | 
                ControlStyles.Opaque |
                ControlStyles.Selectable,
                true);
            DoubleBuffered = true;

            Font = new Font("Verdana", 8.25F, FontStyle.Regular);
            Cursor = Cursors.Hand;
        }
    }
}
