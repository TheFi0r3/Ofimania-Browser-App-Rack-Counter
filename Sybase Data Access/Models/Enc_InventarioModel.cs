using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access.Models
{
    public class Enc_InventarioModel // [dbo].[ENC_INVENTARIO]
    {
        public int? CODINVENTARIO { get; set; } // [CODINVENTARIO] NUMERIC (10) NOT NULL,

        public string? FECHA { get; set; } // [FECHA] DATETIME NOT NULL,

        public string? COD_ALMACEN { get; set; } // [COD_ALMACEN] VARCHAR (4) NOT NULL,

        public string? FECHA_INICIO { get; set; } // [FECHA_INICIO] DATETIME NULL,

        public string? ESTADO { get; set; } // [ESTADO] VARCHAR (1)  NULL,

        public Enc_InventarioModel() { } // CONSTRAINT [PK_ENC_INVENT] PRIMARY KEY CLUSTERED ([CODINVENTARIO] ASC, [COD_ALMACEN] ASC)
    }
}
