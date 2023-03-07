using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp_Tutorial.Data
{
    public class ItemsTable
    {
        public string ItemCode { get; set; }

        public ItemsTable() { }

    }
}
