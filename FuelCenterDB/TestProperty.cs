using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCenterDB
{
    class TestProperty
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int UserId { get; set; }

        public TestProperty(string first, string last, int userId)
        {
            First = first;
            Last = last;
            UserId = userId;
        }
    }
}
