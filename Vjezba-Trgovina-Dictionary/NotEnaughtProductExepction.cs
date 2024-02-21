using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok.Vjezba_Trgovina_Dictionary
{
    public class NotEnaughtProductExepction : Exception
    {
        string message {  get; set; }
        public NotEnaughtProductExepction(string message)
        {
            Console.WriteLine(message);
        }
    }
}
