using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp_Tutorial.Data
{
    public class LoginForms
    {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }

        public LoginForms() { }
    }
}
