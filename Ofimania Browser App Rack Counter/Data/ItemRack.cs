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
    public class ItemRack      
    {
        [Required(ErrorMessage = "Se requiere Codigo de Producto")]
        public string ItemCode { get; set; }

        public string ItemName { get; set; }

        [Required(ErrorMessage = "Se requiere Cantidad de Producto")]
        public int ItemNumb { get; set; }

        public ItemRack() { }

        public ItemRack(string itemCode, string itemName, int itemNumb)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            ItemNumb = itemNumb;
        }

        public void Clear()
        {
            ItemCode = "";
            ItemName = "";
            ItemNumb = 0;
        }
    }
}
