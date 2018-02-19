using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCenterDB
{
    public class Expenses
    {

       public string ExpenseType { get; set; }
       public string Vendor { get; set; }
       public decimal Amount { get; set; }
       public DateTime? SalesDate { get; set; }

       public Expenses()
        {
            ExpenseType = "";
            Vendor = "";
            Amount = 0.00m;
            SalesDate = null;
        }

       public Expenses(string expenseType, string vendor, decimal amount, DateTime salesdate)
        {
            ExpenseType = expenseType;
            Vendor = vendor;
            Amount = amount;
            SalesDate = salesdate;
        }
    }
}
