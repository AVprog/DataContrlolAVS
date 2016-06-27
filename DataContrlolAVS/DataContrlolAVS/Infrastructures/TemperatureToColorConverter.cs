using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using DataContrlolAVS.Model;

namespace DataContrlolAVS.Infrastructures
{
    public class TemperatureToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

          

            if ((double)value > 30 * 0.9)
            {
                return Color.Red;
            }
            else
            if ((double)value < 18 * 1.1)
            {
                return Color.Blue;
            }
            else
            {
                return Color.Green;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
