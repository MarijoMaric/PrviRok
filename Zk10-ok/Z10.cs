using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok
{
    internal class Z10
    {
        public static void RunZ10()
        {
            List<Task> list = new List<Task>();
            Func<Task, bool> filter = x => x.Period % 2 == 0;

            Task task = new Task("Prvi", 2, 3);
            Task task1 = new Task("Prvi", 2, 4);
            Task task2 = new Task("Prvi", 2, 5);
            Task task3 = new Task("Prvi", 2, 16);

            list.Add(task);
            list.Add(task1);
            list.Add(task2);
            list.Add(task3);
            
            List<Task> filteredTasks = new List<Task>();

            filteredTasks = Profiler.Filter(list, filter);

            foreach (var item in filteredTasks)
            {
                Console.WriteLine(item.Period);
            }
        }

    }
}
