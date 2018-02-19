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
    public  class ExpensesData : Expenses
    {
        // ExpensesData: Will mostly deal with the data from the database.
        public int SalesDateId { get; set; }
        public int ExpensesId { get; set; }
        public int VendorId { get; set; }
        public int ExpenseTypeId { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public string UserFirst { get; set; }
        public int TenderTypeId { get; set; }
        public string TenderType { get; set; }
        public bool Cleared { get; set; }
        public string Message { get; set; }
        public string CheckNo { get; set; }
        public string CheckNotes { get; set; }

        public ExpensesData() : base()
        {
            SalesDateId = 0;
            ExpensesId = 0;
            VendorId = 0;
            ExpenseTypeId = 0;
            Description = "";
            UserId = 0;
            UserFirst = "";
            TenderTypeId = 0;
            TenderType = "";
            Message = "";
            Cleared = false;
            CheckNo = "";
            CheckNotes = "";
            
        }
        public ExpensesData(string expenseType, string vendor, decimal amount, DateTime salesdate) : base (expenseType, vendor, amount, salesdate)

        {
            SalesDateId = 0;
            ExpensesId = 0;
            VendorId = 0;
            ExpenseTypeId = 0;
            Description = "";
            UserId = 0;
            UserFirst = "";
            TenderTypeId = 0;
            TenderType = "";
            Message = "";
            Cleared = false;
            CheckNo = "";
            CheckNotes = "";
        }

        // Create overloaded methods to return expenses data by expenseid
        // *** When entering an expenseId it will only return and populate one class
        public ExpensesData(int expensesId)
        {  //*********************UNFINISHED CLASS****************
            // this will populate an Expenses Class
            DBAccess db = new FuelCenterDB.DBAccess();
            SqlConnection sqlConnect = db.CreateFuelDBConnection();
            string sqlSelect = "";
            SqlCommand sqlCommand = db.SetFuelDBCommandTypeStoredProcedure(sqlConnect, sqlSelect);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = sqlCommand;


        }

        public DataSet GetExpensesListByDate(int dateId)
        {
            DataSet dsExpenses = new DataSet();
            DBAccess db = new FuelCenterDB.DBAccess();
            SqlConnection sqlConnect = db.CreateFuelDBConnection();
            string sql = "uspGetExpensesListByDateId";
            SqlCommand sqlCommand = db.SetFuelDBCommandTypeStoredProcedure(sqlConnect, sql);

            try
            {
                sqlConnect.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlCommand;
                da.SelectCommand.Parameters.AddWithValue("@DateID", (int)dateId);
                da.Fill(dsExpenses);
                dsExpenses.Tables[0].TableName = "ExpensesDataList";

            }
            catch (SqlException ex)
            {
                Message = ex.Message;
            }
            finally
            {
                db.CloseConnection(ref sqlConnect);
            }
            return dsExpenses;
        }

        //Get ExpenseType - Returns Dict for Expenses Type - repair, taxes, fees
        public Dictionary<int, string> GetExpenseType()
        {
            Dictionary<int, string> dictExpenseType = new Dictionary<int, string>();

            DBAccess db = new DBAccess();
            SqlConnection sqlConnect = db.CreateFuelDBConnection();
            SqlCommand sqlCommand = db.SetFuelDBCommandTypeStoredProcedure(sqlConnect, "uspGetExpenseTypeList");

            try
            {

                sqlConnect.Open();
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                
                if (sqlReader.HasRows == true)
                {
                    while (sqlReader.Read())
                    {
                        dictExpenseType.Add((int)sqlReader["ExpensesTypeId"], (string)sqlReader["ExpenseType"]);
                    }
                }
                else
                {
                    dictExpenseType.Add(0, "");
                }
                
                sqlReader.Close();
            }

            catch (SqlException ex)
            { Message = ex.Message; }
            catch (Exception ex)
            { Message = ex.Message; }
            finally
            { db.CloseConnection(ref sqlConnect); }

            return dictExpenseType;
        }

        //GetTenderType - Returns dict for how a customer paid
        public Dictionary<int, string> GetTenderType()
        {
            Dictionary<int, string> dictTenderType = new Dictionary<int, string>();

            DBAccess db = new DBAccess();
            SqlConnection sqlConnect = db.CreateFuelDBConnection();
            SqlCommand sqlCommand = db.SetFuelDBCommandTypeStoredProcedure(sqlConnect, "uspGetTenderTypeList");

            try
            {
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                    if (sqlReader.HasRows == true)
                    {
                        while (sqlReader.Read())
                        {
                            dictTenderType.Add((int)sqlReader["TenderTypeId"], (string)sqlReader["TenderType"]);
                        }
                    }
                    else
                    {
                        dictTenderType.Add(0, "");
                    }
                    sqlReader.Close();
                }
            }
            catch (SqlException ex)
            { Message = ex.Message; }
            catch (Exception ex)
            { Message = ex.Message; }
            finally
            { db.CloseConnection(ref sqlConnect); }

            return dictTenderType;
        }

        //GetUserData - Returns list of Users' Info
        public DataSet GetExpensesListByDateId(int dateId)
        {
            DataSet dsExpenses = new DataSet();
            dsExpenses.Tables[0].TableName = "ExpensesList";
            DBAccess db = new FuelCenterDB.DBAccess();
            SqlConnection sqlConnect = db.CreateFuelDBConnection();
            SqlCommand sqlCommand = db.SetFuelDBCommandTypeStoredProcedure(sqlConnect, "uspGetExpensesListByDateID");
            sqlCommand.Parameters.AddWithValue("@DateId", null).Value = dateId;
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = sqlCommand;
            sqlDA.Fill(dsExpenses.Tables["ExpensesList"]);

            return dsExpenses;
        }
        

    }
}
