using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CharGenWpf
{
    public class MyConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var rr = value.ToString();
            return rr;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
        
            var rr = int.Parse(value.ToString());
            return rr;
        }

    }
}
