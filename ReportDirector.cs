using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
    public class ReportDirector
    {
        private DailyReportBuilder reportBuilder;

        public ReportDirector(DailyReportBuilder builder)
        {
            reportBuilder = builder;
        }

        public void ConstructReport()
        {
            reportBuilder.CreateReport();
        }
    }
}
