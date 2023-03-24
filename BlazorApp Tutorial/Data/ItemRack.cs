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
    public class ItemRack      
    { 
        public int ItemCode { get; set; }

        public string ItemName { get; set; }

        public int ItemNumb { get; set; }

        public ItemRack() { }

        public ItemRack(int itemCode, string itemName, int itemNumb)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            ItemNumb = itemNumb;
        }

        public void Clear()
        {
            ItemCode = 0;
            ItemName = "";
            ItemNumb = 0;
        }
    }
}
