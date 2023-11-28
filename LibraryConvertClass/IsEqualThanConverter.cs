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
    /// Класс проверки равенства двух целочесленных переменных.
    /// </summary>
    public class IsEqualThanConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            IComparable v1 = values[0] as IComparable;
            IComparable v2 = values[1] as IComparable;

            if (v1 == null || v2 == null)
                throw new FormatException("to use this converter, value and parameter shall inherit from Double");

            return (int)v1 == (int)v2;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException("Not implemented");
        }
    }
}
