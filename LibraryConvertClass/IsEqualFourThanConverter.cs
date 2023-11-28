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
    /// Класс проверки 4-ёх параметров: общее кол-во позиций, кол-ва изготовленных позиций, переданных позиций и
    /// принытых позиций.
    /// </summary>
    public class IsEqualFourThanConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            IComparable v1 = values[0] as IComparable; // Количество.
            IComparable v2 = values[1] as IComparable; // Изготовлено.
            IComparable v3 = values[2] as IComparable; // Передано.
            IComparable v4 = values[3] as IComparable; // Принято.

            if (v1 == null || v2 == null || v3 == null || v4 == null)
                throw new FormatException("to use this converter, value and parameter shall inherit from Int32");


            if ((int)v2 == 0 && (int)v3 == 0 && (int)v4 == 0) { return 0; } // Пусто.

            if (((int)v2==(int)v1 && ((int)v3==0 || (int)v3==(int)v1) && ((int)v4==0 || (int)v4==(int)v1)) ||
                ((int)v3==(int)v1 && ((int)v2==0 || (int)v2==(int)v1) && ((int)v4==0 || (int)v4==(int)v1)) ||
                ((int)v4==(int)v1 && ((int)v2==0 || (int)v2==(int)v1) && ((int)v3==0 || (int)v3==(int)v1))) { return 2; } // Готово.

            if ((int.Equals((int)v2, 0) == false || int.Equals((int)v3, 0) == false || (int.Equals((int)v4, 0) == false)) && 
                ((int)v2<(int)v1 || (int)v3<(int)v1 || (int)v4<(int)v1)) { return 1; } // В процессе.

            //if ((int.Equals((int)v2, 0)==false && (int)v2<(int)v1) || (int.Equals((int)v3, 0) == false && (int)v3 < (int)v1) ||
            //   (int.Equals((int)v4, 0) == false && (int)v4 < (int)v1)) { return 1; } // В процессе.

            else { return 0; }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException("Not implemented");
        }
    }
}
