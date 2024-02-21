using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok
{
    public class ListeningReport
    {
        public Genre genre{get; set;}
        public double ListenedTime { get; set; }
        public double RemainingTime { get; set; }

        public ListeningReport(double ListenedTime, double RemainingTime, Genre genre) {
        
            this.ListenedTime = ListenedTime;
            this.RemainingTime = RemainingTime;
            this.genre = genre;
        }
    }
}
