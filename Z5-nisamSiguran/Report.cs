using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PrviRok
{
    public abstract class Report
    {
        public string Title { get; set; }
        public string Contents { get; set; }
        public Report(string Title, string Contents) {
        
            this.Title = Title;
            this.Contents = Contents;
        
        }
        public abstract Report Mask(string[] keyWord);

    }
}
