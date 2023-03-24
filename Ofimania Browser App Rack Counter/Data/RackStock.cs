using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Numerics;
using System.Threading.Tasks;

namespace BlazorApp_Tutorial.Data
{
    public class RackStock
    {
        public int RackCode { get; set; }

        public string RackName { get; set; }

        public RackStock() { } 

        public RackStock(int rackCode, string rackName)
        {
        
            RackCode = rackCode;
            RackName = rackName;
        }

        public void Clear()
        { 
            RackCode = 0;
            RackName = "";
        }
    }
}
