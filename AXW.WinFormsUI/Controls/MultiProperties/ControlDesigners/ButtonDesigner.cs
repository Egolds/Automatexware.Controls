using System.Collections;
using System.Windows.Forms.Design;

namespace AXW.WinFormsUI.Controls.MultiProperties.ControlDesigners
{
    public class ButtonDesigner : ControlDesigner
    {
        protected override void PostFilterProperties(IDictionary properties)
        {
            base.PostFilterProperties(properties);
            properties.Remove("BackColor");
        }
    }
}
