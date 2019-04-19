using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Animation.Wpf.Transitions
{
    public class NameToImagePathConverter : IValueConverter
    {

        public object Convert(object value, Type targertType, object parameter, CultureInfo culture)
        {
            string strUri = string.Format(@"/images/{0}.png", (string)value);
            return new BitmapImage(new Uri(strUri, UriKind.Relative));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
