using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok
{
    public interface ITaskProcessor
    {
        int CountImportant(List<Task> tasks);
        List<DateTime> GetNotificationTimestamps(List<Task> tasks);
    }
}
