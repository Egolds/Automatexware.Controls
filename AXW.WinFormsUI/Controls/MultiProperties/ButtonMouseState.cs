using AXW.WinFormsUI.Controls.MultiProperties.Attributes;
using AXW.WinFormsUI.Controls.MultiProperties.Converters;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AXW.WinFormsUI.Controls.MultiProperties
{
    [TypeConverter(typeof(ButtonMouseStateConverter))]
    public sealed class ButtonMouseState // : PropertyTabAttribute
    {
        public ButtonMouseState(Control owner)
        {
            this.owner = owner;
        }

        private Control owner;
        private Color backColor;
        private Color borderColor;
        private Color fontColor;

        [Browsable(true), ApplicableToColorState, EditorBrowsable(EditorBrowsableState.Always)]
        public Color BackColor
        {
            get => backColor; set
            {
                backColor = value;
                OnPropertyChanged();
            }
        }

        [Browsable(true), ApplicableToColorState, EditorBrowsable(EditorBrowsableState.Always)]
        public Color BorderColor
        {
            get => borderColor; set
            {
                borderColor = value;
                OnPropertyChanged();
            }
        }

        // NotifyParentProperty(true), RefreshProperties(RefreshProperties.All)
        [Browsable(true), ApplicableToColorState, EditorBrowsable(EditorBrowsableState.Always)]
        public Color FontColor
        {
            get => fontColor; set
            {
                fontColor = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged()
        {
            owner?.Refresh();
            //owner?.Invalidate();
        }
    }
}
