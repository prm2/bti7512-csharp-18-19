using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace MySchedule.Converter
{
    class TimeToMarginConverter : IValueConverter
    {
        public double UnitsPerHour { get; set; } = 30.0;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double val = 0.0;
            if (value is TimeSpan)
                val = ((TimeSpan)value).TotalHours * UnitsPerHour;

            if (value is DateTime)
                val = (((DateTime)value).Hour - 6 + ((DateTime)value).Minute / 60.0) * UnitsPerHour;

            return new Thickness(3.0, val, 3.0, 0.0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
