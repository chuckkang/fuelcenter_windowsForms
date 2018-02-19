using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace FuelCenterDB

{
    public class SalesDepartment
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public string Message { get; set; }
        //protected internal List<SalesDepartment> SalesDepartmentList { get; set; }

        public SalesDepartment()
        {
            DeptID = 0;
            DeptName = "";
            Message = "";
            //SalesDepartmentList = null;
        }

        public SalesDepartment(int deptID) : base()
        {
            DeptID = deptID;
        }

        public string GetSalesDeptDataByDeptID(int deptID)
        {
            string deptName = "";
            DeptID = deptID;
            string storedProcedureName = "uspGetSalesDeptData";
            DBAccess dbAccess = new DBAccess();
            SqlConnection sqlConnect = dbAccess.CreateFuelDBConnection();
            SqlCommand sqlCommand = dbAccess.SetFuelDBCommandTypeStoredProcedure(sqlConnect, storedProcedureName);

                return deptName;
        }

        public Dictionary<int, string> GetSalesDepartmentList()
        {
            DBAccess dbAccess = new FuelCenterDB.DBAccess();
            Dictionary<int, string> dictSalesDept = new Dictionary<int, string>();
            string storedProcedureName = "uspGetSalesDeptList";
            
            SqlConnection sqlConnect = dbAccess.CreateFuelDBConnection();
            SqlCommand sqlCommand = dbAccess.SetFuelDBCommandTypeStoredProcedure(sqlConnect, storedProcedureName);

            try
            {
                sqlConnect.Open();
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                //int counter = 0;
                if (sqlReader.HasRows == true)
                {
                    while (sqlReader.Read())
                    {
                        dictSalesDept.Add((int)sqlReader["SalesDeptID"], (string)sqlReader["SalesDept"]);
                    }
                }
                sqlReader.Close();
            }
            catch (SqlException ex)
            { Message = ex.Message; }
            catch (Exception ex)
            { Message = ex.Message; }
            finally
            { dbAccess.CloseConnection(ref sqlConnect); }
            return dictSalesDept;

        }
    }
}
