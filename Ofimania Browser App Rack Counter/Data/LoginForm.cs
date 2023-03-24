using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ofimania_Browser_App_Rack_Counter.Data
{
    public class LoginForms
    {
        [Required(ErrorMessage = "Se requiere Nombre de Usuario")]
        public string UserId { get; set; }

        public string UserName { get; set; }

        [Required(ErrorMessage = "Se requiere Contraseña")]
        public string UserPassword { get; set; }

        public LoginForms() { }
    }
}
