using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Numerics;
using System.Threading.Tasks;

namespace Ofimania_Browser_App_Rack_Counter.Data
{
    public class RackStock
    {
        public string RackCode { get; set; }

        public string RackName { get; set; }

        public RackStock() { } 

        public RackStock(string rackCode, string rackName)
        {
            RackCode = rackCode;
            RackName = rackName;
        }

        public void Clear()
        { 
            RackCode = "";
            RackName = "";
        }
    }
}
