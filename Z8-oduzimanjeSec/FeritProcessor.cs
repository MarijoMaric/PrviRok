using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok
{
    public class FeritProcessor : ITaskProcessor
    {
        //napraviti novu klasu sa 2 metode samo?
        public int CountImportant(List<Task> tasks)
        {
            int averagePeriod = 0;
            int counter = 0;
            foreach (var task in tasks)
            {
                averagePeriod += task.Period;

            }

            averagePeriod = averagePeriod/ tasks.Count;

            foreach (var task in tasks)
            {
                if(task.Period > averagePeriod + (averagePeriod * 0.2) || task.Period < averagePeriod - (averagePeriod * 0.2))
                {
                    counter++;
                }

            }
            return counter;

        }

        public List<DateTime> GetNotificationTimestamps(List<Task> tasks)
        {
            List<DateTime> finsihedTimes = new List<DateTime>();
            DateTime time = DateTime.Now;
            
            int averagePeriod = 0;        
            foreach (var task in tasks)
            {
                averagePeriod += task.Period;

            }
            averagePeriod = averagePeriod / tasks.Count;

            foreach (var task in tasks)
            {

                if (task.Period > averagePeriod + (averagePeriod * 0.2) || task.Period < averagePeriod - (averagePeriod * 0.2))
                {
                    //zanimljiv nacin dodavanja jel bilo to i trazeno?
                    DateTime newTime = new DateTime();
                    newTime = time.AddSeconds(task.Duration);
                    finsihedTimes.Add(newTime);
                }
            }

            return finsihedTimes;
        }
    }
}
