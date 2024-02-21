using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok
{
    public class Task
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Period { get; set; }
        public Task(string Name, int Duration, int Period)
        {
            this.Name = Name;
            this.Duration = Duration;
            this.Period = Period;
        }

    }
}
