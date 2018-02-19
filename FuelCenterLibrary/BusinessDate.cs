using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace FuelCenterDB
{
    public class BusinessDate
    {
        // Business date class
        // for theh most part Sales Date and Business date are usually interchangeable.
        //Upon instantiating the class with either a known sales date or sales date id, the class will auto retrieve the rest of the data when instantiated.
          //  the messages brought about will be for general class instantiation, Exception, and sqldb errors.

        public DateTime? SalesDate { get; set; } // teh question mark indicates that the date time can be nullable.  Without it you have to have some value to it.      

        public int SalesDateID { get; set; }

        public string Message { get; set;  } //General message about instantiating about the direct class - ie - recrods not found
        
        public string MessageError { get; set; } // General Exception Error
        
        public string MessageErrorDB { get; set; }

        // create empty constructor
        public BusinessDate()
        {
            SalesDate = null;
            SalesDateID = 0; // 0 = no records found, -1 = error exists with sql, exception or other
            Message = "";
            MessageError = "";
            MessageErrorDB = "";
        }

        public BusinessDate(DateTime salesdate) : this ()
        {  //  when instantiating this class, it will automatically search for the associated Salesdate and SalesDateID
            SalesDate = salesdate;
            SalesDateID = GetSalesDateIDBySalesDate(salesdate);
        }

        public BusinessDate(int dateID) : this()
        {  // overload constructor accepting with int or datetime
            SalesDateID = dateID;
            SalesDate = GetSalesDateByDateID(dateID);
        }

        public int GetSalesDateIDBySalesDate(DateTime businessdate)
        {  // will retrieve sales date id from the given business date.
        // however, it will not be a method available to an instantiated class.
        //  the stored procedure in this will create a new sales date and sales date id if one does not exist.

            int salesdateid = 0;
            
            string sql = "uspGetOrInsertSalesDateID";

            DBAccess fuelDB = new DBAccess();
            SqlConnection sqlConn = fuelDB.CreateFuelDBConnection();
            SqlCommand sqlComm = fuelDB.SetFuelDBCommandTypeStoredProcedure(sqlConn, sql);
            sqlComm.Parameters.AddWithValue("@SalesDate", SqlDbType.DateTime);
            sqlComm.Parameters["@SalesDate"].Value = businessdate;
            // when having an OUTPUT in the stored procedure, you still need to specify the OUTPUT parameter
            // Since we are using executescalar because we are not returning a recordset, we need to specify the OUTPUT parameter
            // So we create an output parameter.  This parameter can be accesssed after the executenonquery has occured.
            SqlParameter returnSalesDateId = new SqlParameter("@SalesDateId", SqlDbType.Int);
            returnSalesDateId.Direction = ParameterDirection.Output;
            sqlComm.Parameters.Add(returnSalesDateId);

            try
            {
                sqlConn.Open();
                sqlComm.ExecuteScalar();
                //int counter = 0;
                // the stored procedure should always return a sales date because it will either select or create a new salesdate record.

                        salesdateid = (int)returnSalesDateId.Value;

            }
            catch (SqlException ex)
            {
                salesdateid = -1; // error exists
                MessageErrorDB = ex.Message; }

            catch (Exception ex)
            {
                salesdateid = -1; // error exists
                MessageError = ex.Message; }

            finally
            { fuelDB.CloseConnection(ref sqlConn); }
            return salesdateid;
        }

        public DateTime? GetSalesDateByDateID(int salesdateid)
        {  // will retrieve sales date from the given business date id.
           // however, it will not be a method available to an instantiated class.
            DateTime? salesdate = null;

            string sql = @"Select Top 1 SalesDate from [Bookkeeping].[SalesDate] where SalesDateID = " + salesdateid + ";";

            DBAccess fuelDB = new DBAccess();
            SqlConnection sqlConn = fuelDB.CreateFuelDBConnection();
            SqlCommand sqlComm = fuelDB.SetFuelDBCommandTypeText(sqlConn, sql);

            try
            {
                sqlConn.Open();
                SqlDataReader sqlReader = sqlComm.ExecuteReader();
                //int counter = 0;
                if (sqlReader.HasRows == true)
                {
                    while (sqlReader.Read())
                    {
                        salesdate = (DateTime)sqlReader["SalesDate"];
                    }
                    sqlReader.Close();
                }
                else
                { return salesdate; }
            }
            catch (SqlException ex)
            {
                //salesdateid = -1; // error exists
                MessageErrorDB = ex.Message;
            }

            catch (Exception ex)
            {
                 // error exists
                MessageError = ex.Message;
            }

            finally
            { fuelDB.CloseConnection(ref sqlConn); }
            return salesdate;
        }

    }
}
