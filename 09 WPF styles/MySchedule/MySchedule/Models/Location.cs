using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchedule.Models
{
    public class Location
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public static Location MainBuilding = new Location
        {
            Name = "Biel, Hauptgebäude",
            Color = "bbffcc",
        };
        public static Location RolexBuilding = new Location
        {
            Name = "Biel, Rolex",
            Color = "ffbbcc",
        };
        public static Location Bern = new Location
        {
            Name = "Bern",
            Color = "bbccff",
        };
    }
}
