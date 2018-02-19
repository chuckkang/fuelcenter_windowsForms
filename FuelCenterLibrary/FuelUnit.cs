using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCenterDB
{
    public class FuelUnit
    {
        public decimal Price{get; set;}
        public int FuelType { get; set; } // 1 is unleaded, 2 is plus, and 3 is Premium-..
        public int NumberOfUnits { get; set; }

        public FuelUnit()
        {
            Price = 0.000m;
            FuelType = 1;
            NumberOfUnits = 0;
        }

        public FuelUnit(int fuelType) : this ()
        {   
            FuelType = fuelType;
            
        }
        public FuelUnit(int fuelType, decimal price) : this(fuelType)
        {
            Price = price;
        }
        public FuelUnit(int fuelType, decimal price, int NumberOfUnits) : this (fuelType, price)
        {
            NumberOfUnits = 1;
        }
        public string GallonToString()
        {
            return "FuelType=" + FuelType + ", Price-" + Price + ", NumberOfUnits-" + NumberOfUnits + ";";
        }

    }
}
