using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchedule.Models
{
    public class Branch
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public static Branch Info = new Branch
        {
            Id = "I",
            Name = "Informatik"
        };
        public static Branch MedInf = new Branch
        {
            Id = "X",
            Name = "Medizininformatik"
        };
        public static Branch Wing = new Branch 
        {
            Id = "W",
            Name = "Wirtschaftsingenieurwesen"
        };
        public static Branch MSE = new Branch 
        {
            Id = "MSE",
            Name = "Master of Science in Engineering"
        };
}
}
