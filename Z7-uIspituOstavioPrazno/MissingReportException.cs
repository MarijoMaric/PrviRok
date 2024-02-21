using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok
{
    public class MissingReportException : Exception
    {
        public MissingReportException(string message)
        {
            Console.WriteLine(message);
        }
    }
}
