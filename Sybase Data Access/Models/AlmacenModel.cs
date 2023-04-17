using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access.Models
{
    public class AlmacenModel // [dbo].[ALMACEN]
    {
        public string? COD_ALMACEN { get; set; } // [COD_ALMACEN]  VARCHAR (4)  NOT NULL,
        public string? COD_SUCURSAL { get; set; } // [CODSUCURSAL]  VARCHAR (6)  NOT NULL,
        public string? DESC_ALMACEN { get; set; } // [DESC_ALMACEN] VARCHAR (30) NULL,
        public AlmacenModel() { } // CONSTRAINT [PK_ALMACEN] PRIMARY KEY CLUSTERED ([COD_ALMACEN] ASC, [CODSUCURSAL] ASC)
    }
}
