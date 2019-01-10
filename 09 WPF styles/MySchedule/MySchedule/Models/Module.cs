using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchedule.Models
{
    public enum ModuleType { Mandatory, Project, Option };

    public class Module
    {
        public string Title { get; set; }
        public ModuleType Type { get; set; }
        public string Class { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration
        {
            get
            {
                return EndTime - StartTime;
            }
        }
        public Branch Branch { get; set; }
        public Location Location { get; set; }
        public string Room { get; set; }
    }
}
