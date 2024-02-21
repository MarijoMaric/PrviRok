using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrviRok
{
    public class Archive
    {
        Dictionary<string, NewReport> archive;

        public Archive()
        {
            archive = new Dictionary<string, NewReport>();
        }

        public void AddReport(NewReport report)
        {
            if (!archive.ContainsKey(report.Title))
            {
                archive.Add(report.Title, report);
            }


        }

        public NewReport GetReport(string title)
        {
            foreach (var key in archive)
            {
                if (key.Key == title)
                {
                    return key.Value;
                }
            }
            return null; //neki bolji nacin?
        }

        public List<string> Names()//hocete li prihvatiti da vraca Listu?
        {
            List<string> names = new List<string>();
            int counter = 0;
            

            foreach (var item in archive)
            {
                string content = item.Value.Contents;
                string[]words = content.Split(' ');
                foreach (var word in words)
                {
                    if (char.IsUpper(word[0]))
                    {
                        names.Add(word);
                        counter++;
                    }
                }
            } 
                
            if(counter == 0)
            {
                throw new MissingReportException("Nema imena");

            }

            return names;
        }



    }
}
