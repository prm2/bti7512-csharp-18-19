using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchedule.Models
{
    public class Schedule : List<Module>
    {
        public Schedule()
        {
            Add(new Module
            {
                Title = "Informatik-Seminar",
                Type = ModuleType.Project,
                Class = "I2pq",
                StartTime = new DateTime(2018, 9, 17, 8, 20, 0),
                EndTime = new DateTime(2018, 9, 17, 11, 55, 0),
                Location = Location.MainBuilding,
                Room = "405",
                Branch = Branch.Info, 
            });
            Add(new Module
            {
                Title = "Projekt 1",
                Type = ModuleType.Project,
                Class = "I2ab",
                StartTime = new DateTime(2018, 9, 19, 18, 10, 0),
                EndTime = new DateTime(2018, 9, 19, 21, 30, 0),
                Location = Location.Bern,
                Room = "201",
                Branch = Branch.Info,
            });
            Add(new Module
            {
                Title = "SW-Engineering",
                Type = ModuleType.Mandatory,
                Class = "X3r",
                StartTime = new DateTime(2018, 9, 20, 8, 20, 0),
                EndTime = new DateTime(2018, 9, 20, 11, 55, 0),
                Location = Location.RolexBuilding,
                Room = "N.319",
                Branch = Branch.MedInf,
            });
            Add(new Module
            {
                Title = "SW-Engineering",
                Type = ModuleType.Mandatory,
                Class = "X2a",
                StartTime = new DateTime(2018, 9, 20, 12, 45, 0),
                EndTime = new DateTime(2018, 9, 20, 16, 10, 0),
                Location = Location.RolexBuilding,
                Room = "N.521",
                Branch = Branch.MedInf,
            });
            Add(new Module
            {
                Title = "C# Intro",
                Type = ModuleType.Option,
                Class = "",
                StartTime = new DateTime(2018, 9, 20, 16, 15, 0),
                EndTime = new DateTime(2018, 9, 20, 17, 50, 0),
                Location = Location.RolexBuilding,
                Room = "N.321",
                Branch = Branch.Info,
            });
            Add(new Module
            {
                Title = "Web Applications",
                Type = ModuleType.Mandatory,
                Class = "I3/I4",
                StartTime = new DateTime(2018, 9, 21, 8, 20, 0),
                EndTime = new DateTime(2018, 9, 21, 11, 55, 0),
                Location = Location.MainBuilding,
                Room = "408",
                Branch = Branch.Info,
            });
            Add(new Module
            {
                Title = "SW-Engineering",
                Type = ModuleType.Mandatory,
                Class = "X2a",
                StartTime = new DateTime(2018, 9, 21, 12, 45, 0),
                EndTime = new DateTime(2018, 9, 21, 14, 20, 0),
                Location = Location.RolexBuilding,
                Room = "N.521",
                Branch = Branch.MedInf,
            });
            Add(new Module
            {
                Title = "SW-Engineering",
                Type = ModuleType.Mandatory,
                Class = "X3r",
                StartTime = new DateTime(2018, 9, 20, 14, 25, 0),
                EndTime = new DateTime(2018, 9, 20, 16, 10, 0),
                Location = Location.RolexBuilding,
                Room = "N.321",
                Branch = Branch.MedInf,
            });
        }
    }
}
