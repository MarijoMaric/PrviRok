using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok
{
    internal class Z8
    {
        public static void RunZ8()
        {
            Task task1 = new Task("prvi", 172800, 15);
            Task task2 = new Task("prvi", 2, 9);
            Task task3 = new Task("prvi", 86400, 20);
            Task task4 = new Task("prvi", 3, 1);

            List<Task> tasks = new List<Task>();
            tasks.Add(task1);
            tasks.Add(task2);
            tasks.Add(task3);
            tasks.Add(task4);

            FeritProcessor processor = new FeritProcessor();
            List<DateTime> newTasks = new List<DateTime>();
            newTasks = processor.GetNotificationTimestamps(tasks);

            foreach (DateTime t in newTasks)
            {
                Console.WriteLine(t.ToString());
            }
        }

    }
}
