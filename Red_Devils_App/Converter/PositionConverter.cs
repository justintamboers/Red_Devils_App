using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Devils_App.Converter
{
    internal class PositionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (typeof(int) == value.GetType())
            {
                int number = (int)value;
                if (number == 1 || number == 22)
                {
                    return "Keeper";
                }
                else if (number >= 2 && number <= 4)
                {
                    return "Verdediger";
                }
                else if (number >= 5 && number <= 8)
                {
                    return "Middelvelder";
                }
                else if (number >= 9 && number <= 11)
                {
                    return "Aanvaller";
                }
                else return "Reserve";
            }
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
