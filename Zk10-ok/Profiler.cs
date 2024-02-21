using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok
{
    public static class Profiler
    {

        public static List<Task> Filter(List<Task> tasks, Func<Task, bool> filter)
        {
            List<Task> result = new List<Task>();
            foreach (var task in tasks)
            {
                if (filter(task))
                {
                    result.Add(task);
                }

            }
            return result;
        }

    }
}
