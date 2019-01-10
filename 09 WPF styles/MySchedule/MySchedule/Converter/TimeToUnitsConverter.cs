using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MySchedule.Converter
{
    class TimeToUnitsConverter : IValueConverter
    {
        public double UnitsPerHour { get; set; } = 30.0;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is TimeSpan)
                return ((TimeSpan)value).TotalHours * UnitsPerHour;

            if (value is DateTime)
                return (((DateTime)value).Hour + ((DateTime)value).Minute / 60.0) * UnitsPerHour;

            return 0.0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
