using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access.Models
{
    public class Producto_Referencia // [dbo].[PRODUCTO_REFERENCIA]
    {
        public string? COD_REFERENCIA { get; set; } // [COD_REFERENCIA] VARCHAR(20) NOT NULL,
        public string? CODPROD { get; set; } // [CODPROD] VARCHAR(20) NOT NULL,
        public string? CODUSUA { get; set; } // [CODUSUA] VARCHAR(20) NULL,
        public string? FECREG { get; set; } // [FECREG] DATETIME NULL,
        public string? FECREGELIM { get; set; } // [FECREGELIM] DATETIME NULL,
        public string? NOMEQUIELIM { get; set; } // [NOMEQUIELIM] VARCHAR(20) NULL,
        public string? NOMUSUAELIM { get; set; } // [NOMUSUAELIM] VARCHAR(30) NULL,
        public string? REGELIM { get; set; } // [REGELIM] CHAR(1) NOT NULL,
        public string? NOMEQUIREG { get; set; } // [NOMEQUIREG] VARCHAR(20) NULL,
        public int? IND_ACT { get; set; } // [IND_ACT] INT DEFAULT((0)) NOT NULL,
        public Producto_Referencia() { } // CONSTRAINT [PK_PRODUCTO_REFERENCIA] PRIMARY KEY CLUSTERED ([COD_REFERENCIA] ASC, [CODPROD] ASC, [REGELIM] ASC)
    }
}
