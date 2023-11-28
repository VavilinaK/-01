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
    /// Проверка, что целочисленная переменная больше нуля.
    /// </summary>
    public class IsGreaterNullThanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            IComparable v1 = value as IComparable;

            if (v1 == null)
                throw new FormatException("to use this converter, value and parameter shall inherit from Double");

            return (int)v1 > 0;
        }

        public object ConvertBack(object value, Type targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException("Not implemented");
        }
    }
}
