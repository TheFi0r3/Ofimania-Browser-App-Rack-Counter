using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access.Models
{
    public class UbicacionModel // [dbo].[UBICACION]
    {
        public string? CODRACK { get; set; } // [CODRACK] VARCHAR(4) NOT NULL,
        public string? CODPROD { get; set; } // [CODPROD] VARCHAR(20) NOT NULL,
        public int? NUMPASI { get; set; } // [NUMPASI] DECIMAL(2) NOT NULL,
        public string? ORIGEN { get; set; } // [ORIGEN] VARCHAR(3) NULL,
        public string? CODUSUA { get; set; } // [CODUSUA] VARCHAR(20) NULL,
        public string? FECREG { get; set; } // [FECREG] DATETIME NULL,
        public string? FECREGELIM { get; set; } // [FECREGELIM] DATETIME NULL,
        public string? NOMEQUIELIM { get; set; } // [NOMEQUIELIM] VARCHAR(20) NULL,
        public string? NOMUSUAELIM { get; set; } // [NOMUSUAELIM] VARCHAR(30) NULL,
        public string? REGELIM { get; set; } // [REGELIM] CHAR(1) NULL,
        public string? NOMEQUIREG { get; set; } // [NOMEQUIREG] VARCHAR(20) NULL,
        public string? CODALMACEN { get; set; } // [CODALMACEN] VARCHAR(4) NOT NULL,
        public string? SECCION { get; set; } // [SECCION] VARCHAR(4) NOT NULL,
        public string? CODSUCURSAL { get; set; } // [CODSUCURSAL] VARCHAR(4) NULL,
        public int? ORDEN { get; set; } // [ORDEN] INT NULL,
        public string? REFERENCIA { get; set; } // [REFERENCIA] VARCHAR(20) NULL,
        public int? ITEM { get; set; } // [ITEM] NUMERIC(15) IDENTITY(1, 1) NOT NULL,
        public long? CODIGO { get; set; } // [CODIGO] NUMERIC(15) NULL,
        public int? CANT_CARAS { get; set; } // [CANT_CARAS] INT NULL,
        public int? CODITEM { get; set; } // [CODITEM] INT NULL,
        public UbicacionModel() { } // CONSTRAINT [UBICACION_X] PRIMARY KEY CLUSTERED ([CODALMACEN] ASC, [SECCION] ASC, [CODRACK] ASC, [NUMPASI] ASC, [CODPROD] ASC, [ITEM] ASC)
    }
}
