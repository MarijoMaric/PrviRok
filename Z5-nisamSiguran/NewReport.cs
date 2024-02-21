using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok
{
    public class NewReport : Report
    {
       

        public NewReport(string Title, string Contents) : base(Title, Contents)
        {
            

        }

        //Pokusaj
        
        public override Report Mask(string[] keyWord)
        {
            string newContent = this.Contents;

            foreach (string key in keyWord)
            {
                string maskedWord = new string('*', keyWord.Length);
                newContent = newContent.Replace(key, maskedWord);
            }
            NewReport newReport = new NewReport(this.Title, newContent);
            return newReport;
        }
    }
}
