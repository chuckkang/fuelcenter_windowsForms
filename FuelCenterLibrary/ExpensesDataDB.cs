using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FuelCenterDB;
using System.Windows;

namespace FuelCenterDB
{
    public class ExpensesDataDB
    { // Class to retrieve and execute database calls for Expenses processes
        
        // GetExpensesDataListAll: for use to populate comboboxes and datasets for use when requiring additional data ids such as userids, or expensetypeid.
        // since this data will not change regularly, just make one call and get all teh data and put into a dataset.
        public  DataSet GetExpensesDataListAll()
        {
            DataSet dsExpenseLists = new DataSet();
            DBAccess db = new DBAccess();
            SqlConnection sqlConnect = db.CreateFuelDBConnection();
            SqlCommand sqlCommand = db.SetFuelDBCommandTypeStoredProcedure(sqlConnect, "uspGetExpenseListsAll");
            SqlDataAdapter sqlDA = new SqlDataAdapter();
            sqlDA.SelectCommand = sqlCommand;
            sqlDA.Fill(dsExpenseLists);
            dsExpenseLists.Tables[0].TableName = "ExpenseType";
            dsExpenseLists.Tables[1].TableName = "Vendor";
            dsExpenseLists.Tables[2].TableName = "UserName";
            dsExpenseLists.Tables[3].TableName = "TenderType";
            return dsExpenseLists;
        }
        public ErrorMessages ErrorMessage { get; set; }
        // UpdateExpenseDataGridList : This will update the db from the dataset that the ExpensesDataGrid uses.
        // it will return the total number of rows affected
        public ExpensesDataDB()
        {
            ErrorMessages ErrorMessage = new ErrorMessages();
            ErrorMessage.Message = "";
            ErrorMessage.ClassName = "";

        }
        public  int UpdateExpenseDataGridList(DataTable expensesDataSet)
        {
            int rowsAffected = 0;
            DBAccess db = new DBAccess();
            SqlConnection sqlConnect = db.CreateFuelDBConnection();
            SqlCommand sqlCommand = db.SetFuelDBCommandTypeStoredProcedure(sqlConnect, "");

            try
            {
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlCommand = db.SetFuelDBCommandTypeStoredProcedure(sqlConnect, "uspDeleteExpenseRecordsByExpenseID");
                sqlCommand.Parameters.AddWithValue("@ExpensesId", SqlDbType.Int);
                sqlCommand.Parameters["@ExpensesId"].SourceColumn = "ExpensesId";
                sqlDA.DeleteCommand = sqlCommand;

                sqlCommand = db.SetFuelDBCommandTypeStoredProcedure(sqlConnect, "uspUpdateExpensesList");
                sqlCommand.Parameters.AddWithValue("@ExpensesId", SqlDbType.Int);
                sqlCommand.Parameters["@ExpensesId"].SourceColumn = "ExpensesId";
                sqlCommand.Parameters.AddWithValue("@VendorId", SqlDbType.Int);
                sqlCommand.Parameters["@VendorId"].SourceColumn = "VendorId";
                sqlCommand.Parameters.AddWithValue("@ExpenseTypeId", SqlDbType.Int);
                sqlCommand.Parameters["@ExpenseTypeId"].SourceColumn = "ExpenseTypeId";
                sqlCommand.Parameters.AddWithValue("@Description", SqlDbType.VarChar);
                sqlCommand.Parameters["@Description"].SourceColumn = "Description";
                sqlCommand.Parameters.AddWithValue("@Amount", SqlDbType.Decimal);
                sqlCommand.Parameters["@Amount"].SourceColumn = "Amount";
                sqlCommand.Parameters.AddWithValue("@UserId", SqlDbType.Int);
                sqlCommand.Parameters["@UserId"].SourceColumn = "UserId";
                sqlCommand.Parameters.AddWithValue("@Cleared", SqlDbType.Bit);
                sqlCommand.Parameters["@Cleared"].SourceColumn = "Cleared";
                sqlCommand.Parameters.AddWithValue("@CheckNo", SqlDbType.VarChar);
                sqlCommand.Parameters["@CheckNo"].SourceColumn = "CheckNo";
                sqlCommand.Parameters.AddWithValue("@CheckNotes", SqlDbType.VarChar);
                sqlCommand.Parameters["@CheckNotes"].SourceColumn = "CheckNotes";
                sqlCommand.Parameters.AddWithValue("@DateId", SqlDbType.Int);
                sqlCommand.Parameters["@DateId"].SourceColumn = "DateId";
                sqlDA.UpdateCommand = sqlCommand;

                sqlCommand = db.SetFuelDBCommandTypeStoredProcedure(sqlConnect, "uspInsertExpensesData");
                //sqlCommand.Parameters.AddWithValue("@ExpensesId", SqlDbType.Int);
                //sqlCommand.Parameters["@ExpensesId"].SourceColumn = expensesDataSet.Tables["ExpensesDataList"].Columns["ExpensesId"].ColumnName;
                sqlCommand.Parameters.AddWithValue("@VendorId", SqlDbType.Int);
                sqlCommand.Parameters["@VendorId"].SourceColumn = expensesDataSet.Columns["VendorId"].ColumnName;
                sqlCommand.Parameters.AddWithValue("@ExpenseTypeId", SqlDbType.Int);
                sqlCommand.Parameters["@ExpenseTypeId"].SourceColumn = expensesDataSet.Columns["ExpenseTypeId"].ColumnName;
                sqlCommand.Parameters.AddWithValue("@TenderTypeId", SqlDbType.VarChar);
                sqlCommand.Parameters["@TenderTypeId"].SourceColumn = expensesDataSet.Columns["TenderTypeId"].ColumnName;
                sqlCommand.Parameters.AddWithValue("@Description", SqlDbType.VarChar);
                sqlCommand.Parameters["@Description"].SourceColumn = expensesDataSet.Columns["Description"].ColumnName;
                sqlCommand.Parameters.AddWithValue("@Amount", SqlDbType.Decimal);
                sqlCommand.Parameters["@Amount"].SourceColumn = expensesDataSet.Columns["Amount"].ColumnName;
                sqlCommand.Parameters.AddWithValue("@UserId", SqlDbType.Int);
                sqlCommand.Parameters["@UserId"].SourceColumn = expensesDataSet.Columns["UserId"].ColumnName;
                sqlCommand.Parameters.AddWithValue("@Cleared", SqlDbType.Bit);
                sqlCommand.Parameters["@Cleared"].SourceColumn = expensesDataSet.Columns["Cleared"].ColumnName;
                sqlCommand.Parameters.AddWithValue("@CheckNo", SqlDbType.VarChar);
                sqlCommand.Parameters["@CheckNo"].SourceColumn = expensesDataSet.Columns["CheckNo"].ColumnName;
                sqlCommand.Parameters.AddWithValue("@CheckNotes", SqlDbType.VarChar);
                sqlCommand.Parameters["@CheckNotes"].SourceColumn = expensesDataSet.Columns["CheckNotes"].ColumnName;
                sqlCommand.Parameters.AddWithValue("@DateId", SqlDbType.Int);
                sqlCommand.Parameters["@DateId"].SourceColumn = expensesDataSet.Columns["DateId"].ColumnName;

                sqlDA.InsertCommand = sqlCommand;


                if (expensesDataSet == null)
                { }
                //MessageBox.Show("IT IS NULL");
                else
                    sqlDA.Update(expensesDataSet);
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message);
               // ErrorMessage.ErrorMessage = ex.ErrorMessage;
                //ErrorMessage.ClassName = this.ToString();
            }
            catch (ArgumentNullException ex)
            {
                ErrorMessage.Message = ex.Message;
                ErrorMessage.ClassName = this.ToString();
            }

            catch (Exception ex)
            {
                ErrorMessage.Message = ex.Message;
                ErrorMessage.ClassName = this.ToString();
            }


            return rowsAffected;
        }
    }
}
