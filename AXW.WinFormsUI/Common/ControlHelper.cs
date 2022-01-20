using System.Drawing;
using System.Windows.Forms;

namespace AXW.WinFormsUI.Common
{
    internal static class ControlHelper
    {
        private static readonly ContentAlignment anyRight = ContentAlignment.BottomRight | ContentAlignment.MiddleRight | ContentAlignment.TopRight;
        private static readonly ContentAlignment anyBottom = ContentAlignment.BottomRight | ContentAlignment.BottomCenter | ContentAlignment.BottomLeft;
        private static readonly ContentAlignment anyCenter = ContentAlignment.BottomCenter | ContentAlignment.MiddleCenter | ContentAlignment.TopCenter;
        private static readonly ContentAlignment anyMiddle = ContentAlignment.MiddleRight | ContentAlignment.MiddleCenter | ContentAlignment.MiddleLeft;

        internal static TextFormatFlags TextFormatFlagsForAlignmentGDI(ContentAlignment align)
        {
            TextFormatFlags glyphOverhangPadding = TextFormatFlags.GlyphOverhangPadding;
            glyphOverhangPadding |= TranslateAlignmentForGDI(align);
            return (glyphOverhangPadding | TranslateLineAlignmentForGDI(align));
        }

        internal static TextFormatFlags TranslateAlignmentForGDI(ContentAlignment align)
        {
            if ((align & anyBottom) != ((ContentAlignment)0))
            {
                return TextFormatFlags.Bottom;
            }
            if ((align & anyMiddle) != ((ContentAlignment)0))
            {
                return TextFormatFlags.VerticalCenter;
            }
            return TextFormatFlags.GlyphOverhangPadding;
        }

        internal static TextFormatFlags TranslateLineAlignmentForGDI(ContentAlignment align)
        {
            if ((align & anyRight) != ((ContentAlignment)0))
            {
                return TextFormatFlags.Right;
            }
            if ((align & anyCenter) != ((ContentAlignment)0))
            {
                return TextFormatFlags.HorizontalCenter;
            }
            return TextFormatFlags.GlyphOverhangPadding;
        }

        internal static StringFormat StringFormatForAlignment(ContentAlignment align)
        {
            StringFormat format = new StringFormat();
            format.Alignment = TranslateAlignment(align);
            format.LineAlignment = TranslateLineAlignment(align);
            return format;
        }

        internal static StringAlignment TranslateAlignment(ContentAlignment align)
        {
            if ((align & anyRight) != ((ContentAlignment)0))
            {
                return StringAlignment.Far;
            }
            if ((align & anyCenter) != ((ContentAlignment)0))
            {
                return StringAlignment.Center;
            }
            return StringAlignment.Near;
        }

        internal static StringAlignment TranslateLineAlignment(ContentAlignment align)
        {
            if ((align & anyBottom) != ((ContentAlignment)0))
            {
                return StringAlignment.Far;
            }
            if ((align & anyMiddle) != ((ContentAlignment)0))
            {
                return StringAlignment.Center;
            }
            return StringAlignment.Near;
        }





    }
}
