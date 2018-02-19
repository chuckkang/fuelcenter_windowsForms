using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCenterDB
{
    class Address
    {
        protected internal string StreetNumber { get; set; }
        protected internal string City { get; set; }
        protected internal string State { get; set; }
        protected internal string Zip { get; set; }

        internal Address()
        {
            StreetNumber = "";
            City = "";
            State = "";
            Zip = "";
        }

        internal Address(string streetNumber, string city, string state, string zip)
        {
            StreetNumber = streetNumber;
            City = city;
            State = state;
            Zip = zip;
        }
    }
}
