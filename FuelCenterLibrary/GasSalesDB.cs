using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FuelCenterDB
{
    public class GasSalesDB
    {
        public Exceptions ExceptionsMessages { get; private set; }

        public GasSalesDB()
        {
            ExceptionsMessages = null;
        }

        public ArrayList GetGasSalesByDateId(int salesDateId)
        {
            ArrayList gasRecordsArray = new ArrayList();

                string sqlText = @"Select GasTypeID, GallonsSold, Price, TotalDollarAmount, CostOfGas from Bookkeeping.GasSales where DateID = " + salesDateId + ";";
                //ArrayList gasRecordsArray = new ArrayList();
                DBAccess sqlGasSales = new DBAccess();
                SqlConnection sqlConn = sqlGasSales.CreateFuelDBConnection();
                SqlCommand sqlCommand = sqlGasSales.SetFuelDBCommandTypeText(sqlConn, sqlText);

                try
                {
                    sqlConn.Open();
                    SqlDataReader sqlreader = sqlCommand.ExecuteReader();
                    FuelData gasSalesValues = new FuelData();
                    if (sqlreader.HasRows == true)
                    {
                        while (sqlreader.Read())
                        {
                            //sqlvalues += sqlreader["GallonsSold"].ToString() + ", ";
                            gasRecordsArray.Add(new FuelData()

                            {
                                FuelType = (int)sqlreader["GasTypeId"],
                                SoldAmount = (decimal)sqlreader["GallonsSold"],
                                Price = (decimal)sqlreader["Price"],
                                DollarAmount = (decimal)sqlreader["TotalDollarAmount"],
                                CostOfGas = (decimal)sqlreader["CostOfGas"]
                            });


                        }
                    }
                }
                catch (Exception ex)
                {
                ExceptionsMessages = new FuelCenterDB.Exceptions(ex);
                }
                finally { sqlGasSales.CloseConnection(ref sqlConn); }  
            
            return gasRecordsArray;
        }
        
       public bool UpdateGasSalesChanges(ArrayList arrFuelData, int salesDateId)
        {
            bool isSuccess = false;
            //string sql = "";
            DBAccess fueldb = new DBAccess();
            SqlConnection sqlConn = new SqlConnection();
            sqlConn = fueldb.CreateFuelDBConnection();
            SqlCommand sqlCommand = fueldb.SetFuelDBCommandTypeStoredProcedure(sqlConn, "uspInsertGasSalesData");
            try
            {
                sqlConn.Open();
                
                foreach (FuelData fd in arrFuelData)
                {

                    sqlCommand.Parameters.AddWithValue("@GasTypeId", SqlDbType.Int);
                    sqlCommand.Parameters["@GasTypeId"].Value = fd.FuelType;
                    sqlCommand.Parameters.AddWithValue("@GallonsSold", SqlDbType.Decimal);
                    sqlCommand.Parameters["@GallonsSold"].Value = fd.SoldAmount;
                    sqlCommand.Parameters.AddWithValue("@Price", SqlDbType.Decimal);
                    sqlCommand.Parameters["@Price"].Value = fd.Price;
                    sqlCommand.Parameters.AddWithValue("TotalDollarAmount", SqlDbType.Decimal);
                    sqlCommand.Parameters["@TotalDollarAmount"].Value = fd.SoldAmount;
                    sqlCommand.Parameters.AddWithValue("@CostOfGas", SqlDbType.Decimal);
                    sqlCommand.Parameters["@CostOfGas"].Value = fd.CostOfGas;
                    sqlCommand.Parameters.AddWithValue("@MobilPrice", SqlDbType.Decimal);
                    sqlCommand.Parameters["@MobilPrice"].Value = 0.00m;
                    sqlCommand.Parameters.AddWithValue("@QTPrice", SqlDbType.Decimal);
                    sqlCommand.Parameters["@QTPrice"].Value = 0.00m;
                    sqlCommand.Parameters.AddWithValue("@ChevronPrice", SqlDbType.Decimal);
                    sqlCommand.Parameters["@ChevronPrice"].Value = 0.00m;

                    sqlCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                ExceptionsMessages = new FuelCenterDB.Exceptions(ex);
            }
            finally
            {
                fueldb.CloseConnection(ref sqlConn);
            }





            return isSuccess;
        }
    }
}
