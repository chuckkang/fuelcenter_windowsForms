using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace FuelCenterDB
{
     class DBAccess
    {
        // allow classes to inherit this so that they have generic db functionality
               
        protected internal SqlCommand SetFuelDBCommandTypeText(SqlConnection sqlConn, string sqlStatement)
        {
            // sets a standard generic sqlcommand obj ready for use.  
            // Need to pass in an existing sqlConn obj to set the connection.
            // A sql statement must be passed into this method.
            // It will return a sqlCommand obj.
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = sqlConn;
            sqlCom.CommandType = CommandType.Text;
            sqlCom.CommandTimeout = 10;
            sqlCom.CommandText= @sqlStatement;
            return sqlCom;
        }

        protected internal SqlCommand SetFuelDBCommandTypeStoredProcedure(SqlConnection sqlConn, string sqlStoredProcedureName)
        {
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.CommandTimeout = 10;
            sqlComm.CommandText = sqlStoredProcedureName;
            return sqlComm;
        }
        
        protected internal SqlConnection CreateFuelDBConnection()
        {
            // sets up a generic sql server connection for the fueldb
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = @"Data Source=chucklaptop;Initial Catalog=FuelCenterDB;Integrated Security=True";
            return sqlCon;

        }
        protected internal void CloseConnection(ref SqlConnection sqlConn)
        {
            // sets up a generic sql server close for connection
            if (sqlConn != null && sqlConn.State == ConnectionState.Open)
            { sqlConn.Close(); }
        }

        
    }
}
