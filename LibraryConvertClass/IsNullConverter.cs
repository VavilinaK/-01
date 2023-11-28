using System.Collections.Generic;
using System.Windows.Controls;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;
using System.Linq;
using System.Text;
using System;

namespace LibraryConvertClass
{
    /// <summary>
    /// Проверка, что целочисленная переменная равна 0 или null.
    /// </summary>
    public class IsNullConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return ((value == null) || ((int?)value == 0));
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new InvalidOperationException("IsNullConverter can only be used OneWay.");
        }
    }
}
