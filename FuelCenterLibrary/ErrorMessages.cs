﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCenterDB
{
    public class ErrorMessages
    {
        public string Message { get; set; }
        public string ClassName { get; set; }

        public ErrorMessages()
        {
            Message = "";
            ClassName = "";
        }
    }
}
