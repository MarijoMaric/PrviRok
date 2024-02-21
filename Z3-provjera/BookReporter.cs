using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok
{
    public static class BookReporter
    {
        public static ListeningReport Analyze(List<AudioBook> audioBooks, Genre genre)
        {
            int listenedMinutes = 0;
            int remainingTime = 0;
            

            foreach (AudioBook audioBook in audioBooks)
            {
                if (audioBook.Genre == genre)
                {
                    listenedMinutes += audioBook.MinutesListened;
                    remainingTime += audioBook.DurationMinutes - audioBook.MinutesListened;

                }
            }
            
            ListeningReport listeningReport = new ListeningReport(listenedMinutes, remainingTime, genre);
            
            return listeningReport;

        }
    }
}
