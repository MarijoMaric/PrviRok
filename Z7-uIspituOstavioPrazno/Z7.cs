using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok.Z7_uIspituOstavioPrazno
{
    public class Z7
    {
        public static void RunZ7()
        {
            List<string> names = new List<string>();   
            NewReport porukica = new NewReport("Winter Is Coming", "first season David Benioff & Weiss");
            NewReport porukica2 = new NewReport("Winter Is Coming", "first season");
            NewReport porukica3 = new NewReport("The Kingsroad", "direct by Tim");

            Archive archive = new Archive();
            archive.AddReport(porukica);
            archive.AddReport(porukica2);
            archive.AddReport(porukica3);
            try
            {
                names = archive.Names();
            }catch(MissingReportException) {
                
            }
            

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }

    }
}
