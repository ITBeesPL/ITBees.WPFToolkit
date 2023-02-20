using System;
using System.Globalization;
using System.Windows.Data;

namespace ITBees.WPFToolkit.Converters
{
    public class StringTrimmer : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                var length = System.Convert.ToInt32(parameter);
                var v = (string)value;
                if (v.Length < length)
                {
                    return value;
                }
                else
                {
                    return v.Substring(0, length) + "...";
                }
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}