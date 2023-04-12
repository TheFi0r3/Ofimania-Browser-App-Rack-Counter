using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access.Models
{
    public class Enc_InventarioModel
    {
        public int? CODINVENTARIO { get; set; }

        public string? FECHA { get; set; }

        public int? COD_ALMACEN { get; set; }

        public string? FECHA_INICIO { get; set; }

        public string? ESTADO { get; set; }

        public Enc_InventarioModel() { }
    }
}
