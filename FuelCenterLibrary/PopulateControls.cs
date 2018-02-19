using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace FuelCenterDB
{
    public class PopulateControls
    {
        public string Messages { get; set; }

        public PopulateControls()
        {
            Messages = "";
        }

        public Dictionary<int, string> GetSalesDeptList()
        {
            Dictionary<int, string> deptList = new Dictionary<int, string>();
            SalesDepartment salesDept = new SalesDepartment();

            deptList = salesDept.GetSalesDepartmentList();
            if (salesDept.Message != "")
            { return null; }

            return deptList;
        }

        // ********************populate Expenses drop downs ***********************
        // Need Vendor, User, Expense Type, TenderType, 


        public Dictionary<int, string> GetExpenseTypeList()
        {
            Dictionary<int, string> dictExpenseTypeList = new Dictionary<int, string>();
            ExpensesData expData = new ExpensesData();


            return expData.GetExpenseType();
        }

        public Dictionary<int, string> GetTenderTypeList()
        {
            Dictionary<int, string> dictTenderTypeList = new Dictionary<int, string>();
            ExpensesData expTender = new ExpensesData();


            return expTender.GetTenderType();
        }
        
       public List<UserData> GetUserDataList()
        {
            List<UserData> userList = new List<UserData>();
            UserData ud = new FuelCenterDB.UserData();
            userList = ud.ReturnUserDataList();
            return userList;
        }

       public Dictionary<int, string> GetVendorList()
        {
            VendorDataDB vendorData = new VendorDataDB();
            return vendorData.GetVendorList();
        }
      
        public DataSet GetExpenseListsAll()
        {
            ExpensesDataDB listExpenseLists = new FuelCenterDB.ExpensesDataDB();
            return listExpenseLists.GetExpensesDataListAll();
        }
    }
}
