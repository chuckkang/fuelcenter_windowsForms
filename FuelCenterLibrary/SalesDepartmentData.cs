using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using FuelCenterDB;

namespace FuelCenterDB
{
    public class SalesDepartmentData : SalesDepartment
    {
        //members
         public int Quantity { get; set;  }
         public decimal TotalDollars { get; set; }
         public int SalesDateId { get; set; }
        //protected public string ErrorMessage { get; set; }
         public SqlDataAdapter daSql = new SqlDataAdapter();

         public SalesDepartmentData() : base ()
        {
            Quantity = 0;
            TotalDollars = 0.00m;
        }


         public DataTable GetDepartmentSalesDataByDateID(int dateid)
        {
            DBAccess dbAccess = new DBAccess();
            SqlConnection sqlConn = dbAccess.CreateFuelDBConnection();
            string spName = "uspGetSalesDeptData";
            SqlCommand sqlComm = dbAccess.SetFuelDBCommandTypeStoredProcedure(sqlConn, spName);
            sqlComm.Parameters.Add(new SqlParameter("@SalesDateID", dateid));
            daSql.SelectCommand = sqlComm;

            //daSql.SelectCommand = sqlComm;
            DataTable dataTable = new DataTable();
            daSql.Fill(dataTable);

            return dataTable;
        }
        // InsertsalesDataListDB:  will either update modified data, or insert new data.
        // Requires a List<SalesDeptData>
        // returns total number of rows affected.
         public int InsertSalesDataListDB(List<SalesDepartmentData> listSalesData)
        { // this will update a list of SalesData objects from teh salesdata datagridview. Instead of using a data adapter, a list will be sent to this 
            // method, and will iterate through the list and update each SalesData object seperately.
            int counter = 0;  //  counter- will count how many records were updated.

            DBAccess db = new DBAccess();
            SqlConnection sqlConn = db.CreateFuelDBConnection();
            //SqlCommand sqlComm = db.SetFuelDBCommandTypeStoredProcedure(sqlConn, "uspInsertDepartmentSales");
            string spName = "";
            try
            {
                sqlConn.Open();
                foreach (SalesDepartmentData sales in listSalesData)
                {
                    
                    if (DoesSalesDeptDataExist(sales.SalesDateId))
                    {// if there are records in the db then just do an update of those recoreds
                        spName = "uspUpdateDepartmentsales";
                    }
                    else
                    {// if there are no records then do an insert.
                        spName = "uspInsertDepartmentSales";
                    }
                    SqlCommand sqlComm = db.SetFuelDBCommandTypeStoredProcedure(sqlConn, spName);
                    sqlComm.Parameters.Add(new SqlParameter("@DeptID", sales.DeptID));
                    sqlComm.Parameters.Add(new SqlParameter("@Quantity", sales.Quantity));
                    sqlComm.Parameters.Add(new SqlParameter("@Amount", sales.TotalDollars));
                    sqlComm.Parameters.Add(new SqlParameter("@SalesDateID", sales.SalesDateId));
                    counter++;
                }
                
            }

            catch (SqlException ex)
            {
                Message = ex.Message;
            }
            catch(Exception ex)
            {
                Message = ex.Message;
            }
            finally
            { db.CloseConnection(ref sqlConn); }

            return counter;
        }
        
        // InsertSalesDataListDB - overloaded method
        // will update data based on the changes using the dataadapter
        // need to pass in a datatable, then pass in the sqldataadapter
         public int InsertSalesDataListDB(DataTable dt, SqlDataAdapter da)
        {
            int rowsAffected = 0;
            DBAccess db = new DBAccess();
            SqlConnection sql = db.CreateFuelDBConnection();

            SqlCommand sqlComm = db.SetFuelDBCommandTypeStoredProcedure(sql, "uspUpdateDepartmentSales");
            sqlComm.Parameters.AddWithValue("@DeptID", SqlDbType.Int);
            sqlComm.Parameters["@DeptID"].SourceColumn = "SalesDeptID";
            sqlComm.Parameters.AddWithValue("@Quantity", SqlDbType.Int);
            sqlComm.Parameters["@Quantity"].SourceColumn = "SalesCount";
            sqlComm.Parameters.AddWithValue("@TotalDollars", SqlDbType.Int);
            sqlComm.Parameters["@TotalDollars"].SourceColumn = "Amount";
            sqlComm.Parameters.AddWithValue("@SalesDateId", SqlDbType.Int);
            sqlComm.Parameters["@SalesDateId"].SourceColumn = "DateId";
            da.UpdateCommand = sqlComm;
            //da.Update(dt);

            sqlComm = db.SetFuelDBCommandTypeStoredProcedure(sql, "uspDeleteDeptSalesByDateIDAndSalesDeptID");
            sqlComm.Parameters.AddWithValue("@SalesDeptId", SqlDbType.Int);
            sqlComm.Parameters["@SalesDeptId"].SourceColumn = "SalesDeptID";
            sqlComm.Parameters.AddWithValue("@SalesDateID", SqlDbType.Int);
            sqlComm.Parameters["@SalesDateID"].SourceColumn = "DateId";
            da.DeleteCommand = sqlComm;

            sqlComm = db.SetFuelDBCommandTypeStoredProcedure(sql, "uspInsertDepartmentSales");
            sqlComm.Parameters.AddWithValue("@DeptId", SqlDbType.Int);
            sqlComm.Parameters["@DeptId"].SourceColumn = "SalesDeptID";
            sqlComm.Parameters.AddWithValue("@Quantity", SqlDbType.Int);
            sqlComm.Parameters["@Quantity"].SourceColumn = "SalesCount";
            sqlComm.Parameters.AddWithValue("@TotalDollars", SqlDbType.Decimal);
            sqlComm.Parameters["@TotalDollars"].SourceColumn = "Amount";
            sqlComm.Parameters.AddWithValue("@SalesDateId", SqlDbType.Int);
            sqlComm.Parameters["@SalesDateId"].SourceColumn = "DateId";
            da.InsertCommand = sqlComm;
            
            rowsAffected = da.Update(dt);


            return rowsAffected;
        }

        // GetDeptIDByName - returns the DeptID number 
         public int GetDeptIDByName(string deptName)
        {
            int deptId = -1; // -1 will be a flag indicating that there are no results.
            DBAccess db = new DBAccess();
            SqlConnection sqlConnect = db.CreateFuelDBConnection();
            sqlConnect.Open();
            string sql = "Select SalesDeptId from [Bookkeeping].[SalesDept] where SalesDept = '" + deptName.Trim() + "'";
            using (sqlConnect)
            {
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnect);
                //lblResults2.Text = sql;
                SqlDataReader sqlreader = sqlCommand.ExecuteReader();
                if (sqlreader.HasRows)
                {
                    while (sqlreader.Read())
                    {
                        deptId = (int)sqlreader["SalesDeptId"];
                    }
                }
            }
                return deptId;
        }
        // Method will return bool based on whether there is already data in teh Sales Department table
         public bool DoesSalesDeptDataExist(int salesDate)
        {  

            bool dataExists = false;
            DBAccess dbAccess = new DBAccess();
            SqlConnection sqlConn = dbAccess.CreateFuelDBConnection();
            string spName = "uspGetDepartmentSalesData";
            SqlCommand sqlComm = dbAccess.SetFuelDBCommandTypeStoredProcedure(sqlConn, spName);

            try
            {
                sqlConn.Open();
                sqlComm.Parameters.Add("@SalesDateID");

                int sqlReader = sqlComm.ExecuteNonQuery(); // executenonquery returns an integer
                if (sqlReader > 0)
                {
                    dataExists = true;
                }

            }

            catch (SqlException ex)
            {
                Message = ex.Message;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
            finally
            { dbAccess.CloseConnection(ref sqlConn); }
            return dataExists;
        }
    }
}
