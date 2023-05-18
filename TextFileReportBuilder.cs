using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine
{
    public class TextFileReportBuilder : DailyReportBuilder
    {
        protected override void AddHeader()
        {
            reportLines.Add("-------- Daily Report --------");
        }

        protected override void AddContent()
        {
            // Add content from the payment history
        }

        protected override void AddFooter()
        {
            reportLines.Add("-------------------------------");
        }

        protected override void SaveReportToFile()
        {
            File.WriteAllLines("daily_report.txt", reportLines);
            Console.WriteLine("Report saved to daily_report.txt");
        }
    }
}
