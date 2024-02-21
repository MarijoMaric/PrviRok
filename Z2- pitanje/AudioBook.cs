using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrviRok
{
    public class AudioBook : Book
    {
        public DateTime StartedAt { get; private set; }
        public int DurationMinutes { get; private set; }
        public int MinutesListened { get; private set; }

        

        public AudioBook(string Title, string Author, Genre Genre,DateTime StartedAt, int DurationMinutes, int MinutesListened) : base(Title, Author, Genre){
            this.StartedAt = StartedAt;
            this.DurationMinutes = DurationMinutes;
            this.MinutesListened = MinutesListened;
            
        }
        /* ---------------------------  PITATI  ---------------------------  */
        //ne koristim TotalDays
        public double MinutesPerDayNeeded(DateTime desiredEndDate)
        {
            TimeSpan timeLeft = desiredEndDate - DateTime.Now;
            return (DurationMinutes - MinutesListened) / timeLeft.TotalDays;
        }
    }
}
