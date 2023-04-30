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
        public string ItemCode { get; set; }

        [Required(ErrorMessage = "Se requiere Código de Producto")]
        public string ItemBarCode { get; set; }

        public string ItemName { get; set; }

        [Required(ErrorMessage = "Se requiere Cantidad de Producto")]
        public int? ItemNumb { get; set; }

        public bool ItemInRack { get; set; }

        public ItemRack() { }

        public ItemRack(string itemCode, string itemName, int itemNumb, string itemBarCode, bool itemInRack)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            ItemNumb = itemNumb;
            ItemBarCode = itemBarCode;
            ItemInRack = itemInRack;
        }

        public ItemRack(string itemCode, string itemName, int itemNumb)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            ItemNumb = itemNumb;
            ItemBarCode = itemCode;
            ItemInRack = true;
        }

        public void Clear() { }
    }
}
