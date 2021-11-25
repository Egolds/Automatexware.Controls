using AXW.WinFormsUI.Controls.MultiProperties.Attributes;
using System;
using System.ComponentModel;
using System.Globalization;

namespace AXW.WinFormsUI.Controls.MultiProperties.Converters
{
    internal class ButtonMouseStateConverter : ExpandableObjectConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                return string.Empty;
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            if (context != null && context.Instance is Button)
            {
                Attribute[] array = new Attribute[attributes.Length + 1];
                attributes.CopyTo(array, 0);
                array[attributes.Length] = new ApplicableToButtonMouseStateAttribute();
                attributes = array;
            }
            return TypeDescriptor.GetProperties(value, attributes);
        }
    }
}
