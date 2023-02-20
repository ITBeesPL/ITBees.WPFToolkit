using System;
using System.Globalization;
using System.Windows.Data;

namespace ITBees.WPFToolkit.Converters;

public class UtcToPolishLocalDateTimeConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if(value == null) return null;
        if (value is DateTime dt)
            return dt.ToString("yyy-MM-dd HH:mm");
        else
            return DateTime.Parse(value?.ToString()).ToLocalTime();
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}