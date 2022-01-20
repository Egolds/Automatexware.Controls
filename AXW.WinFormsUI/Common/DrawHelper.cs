using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXW.WinFormsUI.Common
{
    internal static class DrawHelper
    {
        internal static GraphicsPath GetRoundedRectangle(Rectangle rect, float radius)
        {
            float realRadius = radius;// * 2F;
            GraphicsPath gp = new GraphicsPath();
            gp.StartFigure();
            gp.AddArc(rect.X, rect.Y, realRadius, realRadius, 180, 90);
            gp.AddArc(rect.X + rect.Width - realRadius, rect.Y, realRadius, realRadius, 270, 90);
            gp.AddArc(rect.X + rect.Width - realRadius, rect.Y + rect.Height - realRadius, realRadius, realRadius, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - realRadius, realRadius, realRadius, 90, 90);
            gp.CloseFigure();

            gp.AddRectangle(rect);

            return gp;
        }

        internal static GraphicsPath GetRoundedRectangleF(RectangleF rect, float radius)
        {
            float realRadius = radius;// * 2F;
            GraphicsPath gp = new GraphicsPath();
            gp.StartFigure();
            gp.AddArc(rect.X, rect.Y, realRadius, realRadius, 180, 90);
            gp.AddArc(rect.X + rect.Width - realRadius, rect.Y, realRadius, realRadius, 270, 90);
            gp.AddArc(rect.X + rect.Width - realRadius, rect.Y + rect.Height - realRadius, realRadius, realRadius, 0, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - realRadius, realRadius, realRadius, 90, 90);
            gp.CloseFigure();

            return gp;
        }
    }
}
