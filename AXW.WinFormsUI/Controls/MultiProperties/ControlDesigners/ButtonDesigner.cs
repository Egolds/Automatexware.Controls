using System.Collections;
using System.Windows.Forms.Design;

namespace AXW.WinFormsUI.Controls.MultiProperties.ControlDesigners
{
    internal class ButtonDesigner : ControlDesigner
    {
        protected override void PostFilterProperties(IDictionary properties)
        {
            base.PostFilterProperties(properties);
            properties.Remove("BackColor");
            properties.Remove("BackgroundImage");
            properties.Remove("BackgroundImageLayout");
            properties.Remove("FlatStyle");
            properties.Remove("FlatAppearance");
            properties.Remove("UseVisualStyleBackColor");
        }
    }
}
