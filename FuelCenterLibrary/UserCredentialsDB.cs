using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace FuelCenterDB
{
    public class UserCredentialsDB
    {
        // other methods that need to be included:
        // Password Management - update user name and password
        // Creating/Deleting new user
        // 
        //public string DataErrorMessage { get; set; }
        public ErrorMessages Messages
        { get ; set; } = new ErrorMessages();

        public UserCredentialsDB() 
        {
            // DataErrorMessage = "";
            Messages.Message = string.Empty;
            Messages.ClassName = string.Empty;
        }

        public UserData VerifyUserNamePassword(string username, string password)
        {
            // Method accepts username and password and errMessage as a REF so that if there are any db errors
            /// that can be shown.
            //bool userExists = false;
            UserData userData = new UserData();
            string userName = username.ToLower(); // user name  is not case sensitive.

            //****************

            //***************
            DBAccess db = new FuelCenterDB.DBAccess();

            string sql = "uspCheckUserCredentialsByUserNamePassword";

            SqlConnection cn = db.CreateFuelDBConnection();
            SqlCommand cmd = db.SetFuelDBCommandTypeStoredProcedure(cn, sql);
            cmd.Parameters.AddWithValue("@UserName", SqlDbType.VarChar);
            cmd.Parameters["@UserName"].Value = username;
            cmd.Parameters.AddWithValue("@UserPassword", SqlDbType.VarChar);
            cmd.Parameters["@UserPassword"].Value = password;

            try
            {
                cn.Open();
                SqlDataReader sqlResult = cmd.ExecuteReader();
                if (sqlResult.HasRows)
                {
                    while (sqlResult.Read())
                    {
                        userData.UserId = (int)sqlResult["UserID"];
                        userData.FirstName = (string)sqlResult["First"];
                        userData.LastName = (string)sqlResult["Last"];
                    }
                   
                }
                else
                {
                    // This will be the default class that is returned so that the programmer can check if 
                    // data was returned.  If the user id is 0 then nothing was f0und.
                    userData.UserId = 0;
                    Messages.Message = "User Not Found";
                    

                }
                sqlResult.Close();
            }

            catch (SqlException ex)
            { Messages.Message = ex.Message; }
            catch (Exception ex)
            { Messages.Message = ex.Message; }
            finally
            { db.CloseConnection(ref cn); }

            return userData;
        }

    }
}
