using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FuelCenterDB
{
    class VendorDataDB
    {
        // VendorDataDB:  Instead of using the Vendor class to have access to the data base
        // this class will do any Vendor Database activity.  This will insure that the class and the database
        // will remain separate.
        public string Message = "";
        protected internal Dictionary<int, string> GetVendorList()
        {
            Dictionary<int, string> vendorList = new Dictionary<int, string>();
            DBAccess db = new FuelCenterDB.DBAccess();
            SqlConnection sqlConnect = db.CreateFuelDBConnection();
            string sql = "uspGetVendorList";
            SqlCommand sqlCommand = db.SetFuelDBCommandTypeStoredProcedure(sqlConnect, sql);
            
            try
            {
                sqlConnect.Open();
                    using(sqlConnect)
                {
                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                    if (sqlReader.HasRows)
                        while(sqlReader.Read())
                        {
                            vendorList.Add((int)sqlReader["VendorId"], (string)sqlReader["VendorName"]);
                        }
                    sqlReader.Close();
                }
            }
            catch (SqlException ex)
            { Message = ex.Message; }

            catch (Exception ex)
            { Message = ex.Message;}
            finally
            {
                db.CloseConnection(ref sqlConnect);
            }

            //vendorList.OrderBy()
            return vendorList;
        }
        
    }
}
