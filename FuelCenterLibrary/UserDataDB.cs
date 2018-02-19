using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace FuelCenterDB
{
    public class UserDataDB
    {
        public Exceptions Message { get; private set; }


        public List<UserData> GetUsersDataList()
        {

            List<UserData> userData = new List<UserData>();
            DBAccess db = new FuelCenterDB.DBAccess();
            SqlConnection sqlConnect = db.CreateFuelDBConnection();
            string sql = "uspGetUserList";
            SqlCommand sqlCommand = db.SetFuelDBCommandTypeStoredProcedure(sqlConnect, sql);


            try
            {
                using (sqlConnect)
                {
                    sqlConnect.Open();
                    SqlDataReader sqlReader = sqlCommand.ExecuteReader();
                    if (sqlReader.HasRows)
                    {
                        while (sqlReader.Read())
                        {
                            UserData newUser = new FuelCenterDB.UserData((string)sqlReader["First"],
                                (string)sqlReader["Last"],
                                (int)sqlReader["UserId"]);

                            userData.Add(newUser);
                        }
                        sqlReader.Close();
                    }
                }
            }

            catch (Exception ex)
            {
                Message = new Exceptions(ex);
            }
            finally
            { db.CloseConnection(ref sqlConnect); }
            //UserList = userData;

            return userData;
        }
    }
}
