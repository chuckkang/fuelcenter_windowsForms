using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCenterDB
{
    public class FuelData : FuelUnit
    { // properties : Sold, DollarAmount, CostOfGas

        public decimal SoldAmount { get; set; }
        public decimal DollarAmount { get; set; }
         public decimal CostOfGas { get; set; }

         public FuelData() : base ()
        {
            // empty constructor that inherits an empty constructor from gallons
            SoldAmount = 0.000m;
            DollarAmount = 0.00m;
            CostOfGas = 0.000m;
        }
         public FuelData(int fuelType, decimal price, int NumberOfUnits) : base (fuelType, price, NumberOfUnits)
        {
            SoldAmount = 0.000m;
            DollarAmount = 0.00m;
            CostOfGas = 0.000m;
        }
         public FuelData(int fuelType, decimal price, int NumberOfUnits, decimal soldamount, decimal dollaramount, decimal costofgas) : this (fuelType, price, NumberOfUnits)
        {
            SoldAmount = soldamount;
            DollarAmount = dollaramount;
            CostOfGas = costofgas;
        }

         public string ReturnFuelDataClass()
        {
            string fuelDataToString = "";

            fuelDataToString = "FuelType=" + FuelType +
                ", Price=" + Price +
                ", NumberOfUnits=" + NumberOfUnits +
                ", SoldAmount=" + SoldAmount +
                ", DollarAmount=" + DollarAmount +
                ", CostOfGas=" + CostOfGas + ";";
                
            return fuelDataToString;
        }
        }
}
