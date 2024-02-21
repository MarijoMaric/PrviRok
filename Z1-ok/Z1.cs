using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok.Z1_ok
{
    public class Z1
    {

        public static void RunZ1()
        {
            Book enigma = new Book("Alan Turing: The enigma", "Andrew Hodges", Genre.Biography);
            Book another = new Book(enigma);
            another.Genre = Genre.Biography;
            Console.WriteLine($"Book info: {another.Title}, {another.Author}, {another.Genre}");
        }
        
    }
}
