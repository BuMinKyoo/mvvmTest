using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfApp1.Converters
{
    public class BoolTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value as string == "Y";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is bool && (bool)value ? "Y" : "N";
        }
    }
}
