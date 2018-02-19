using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelCenterDB;

namespace FuelCenterDB
{
    class Vendor
    {
        protected internal string Name { get; set; }
        protected internal string Description { get; set; }
        protected internal string Telephone { get; set; }
        protected internal Address VendorAddress { get; set; }

        internal Vendor() : base ()
        {
            Name = "";
            Description = "";
            Telephone = "";
            VendorAddress = null;
        }

        internal Vendor(string name, string description, string telephone) : this ()
        {
            Name = name;
            Description = description;
            Telephone = telephone;
            VendorAddress = null;
        }

        public string VendorToString()
        {
            return "Name-" + Name +  "; Description-" + Description + "; Telephone-" + Telephone;
        }

        public string VendorAddressToString()
        {
            return "Address" + VendorAddress.StreetNumber + "; City-" + VendorAddress.City + "; State-" + 
                VendorAddress.State + "; Zip- " + VendorAddress.Zip;
        }
    }
}
