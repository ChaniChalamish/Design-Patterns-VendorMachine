using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
    public abstract class DailyReportBuilder
    {
        protected List<string> reportLines;

        public void CreateReport()
        {
            reportLines = new List<string>();
            AddHeader();
            AddContent();
            AddFooter();
            SaveReportToFile();
        }

        protected abstract void AddHeader();
        protected abstract void AddContent();
        protected abstract void AddFooter();

        protected abstract void SaveReportToFile();
       
    }
}
