using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaemdll
{
    public class Zaem
    {
        public string CreditAmount { get; set; }
        public string CreditDeadline { get; set; }
        public string YearInterest { get; set; }

        public string MonthlyResult { get; set; }
        public string TotalResult { get; set; }

        public Zaem(string amountStr, string deadlineStr, string interestStr)
        {
            this.CreditAmount = amountStr;
            this.CreditDeadline = deadlineStr;
            this.YearInterest = interestStr;

            double interest = Double.Parse(interestStr) / 100;
            double month = Double.Parse(deadlineStr) / 12;
            double result = Double.Parse(amountStr) * (1 + (interest * month));
            double monthly = result / Double.Parse(deadlineStr);

            TotalResult = Math.Round(result,2).ToString();
            MonthlyResult = Math.Round(monthly).ToString();
        }
    }
}
