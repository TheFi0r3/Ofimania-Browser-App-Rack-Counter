using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access.Models
{
    public class RackMovilModel // [dbo].[RACKMOVIL]
    {
        public string? CODRACK { get; set; } // [CODRACK] VARCHAR(4) NOT NULL,
        public string? CODPROD { get; set; } // [CODPROD] VARCHAR(20) NOT NULL,
        public int? CODINVENTARIO { get; set; } // [CODINVENTARIO] NUMERIC(10) NOT NULL,
        public string? CODSUCURSAL { get; set; } // [CODSUCURSAL] VARCHAR(4) NOT NULL,
        public string? CODALMACEN { get; set; } // [CODALMACEN] VARCHAR(4) NOT NULL,
        public string? CODUSUAC1 { get; set; } // [CODUSUAC1] VARCHAR(20) NULL,
        public string? CODUSAC2 { get; set; } // [CODUSUAC2] VARCHAR(20) NULL,
        public string? CODUSAC3 { get; set; } // [CODUSUAC3] VARCHAR(20) NULL,
        public int? CON1 { get; set; } // [CON1] NUMERIC(10) DEFAULT((0)) NOT NULL,
        public int? CON2 { get; set; } // [CON2] NUMERIC(10) DEFAULT((0)) NOT NULL,
        public int? CON3 { get; set; } // [CON3] NUMERIC(10) NULL,
        public string? FECHA_CONTEO { get; set; } // [FECHA_CONTEO] DATETIME NULL,
        public string? FECHA_GENERACION { get; set; } // [FECHA_GENERACION] DATETIME NOT NULL,
        public string? REFERENCIA { get; set; } // [REFERENCIA] VARCHAR(20) NOT NULL,
        public int? TER1 { get; set; } // [TER1] INT DEFAULT((0)) NULL,
        public int? TER2 { get; set; } // [TER2] INT DEFAULT((0)) NULL,
        public int? MANUAL { get; set; } // [MANUAL] INT DEFAULT((0)) NULL,
        public RackMovilModel() { } // CONSTRAINT [RACKMOVIL_787244021] PRIMARY KEY CLUSTERED ([CODINVENTARIO] ASC, [CODPROD] ASC, [CODRACK] ASC)
    }
}
