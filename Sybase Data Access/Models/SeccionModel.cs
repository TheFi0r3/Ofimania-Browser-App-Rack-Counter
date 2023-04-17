using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access.Models
{
    public class SeccionModel // [dbo].[SECCION]
    {
        public string? CODSEC { get; set; } // [CODSEC] VARCHAR(4) NOT NULL,

        public string? COD_ALMACEN { get; set; } // [COD_ALMACEN] VARCHAR(6) NOT NULL,

        public string? CODSUCURSAL { get; set; } // [CODSUCURSAL] VARCHAR(6) NOT NULL,

        public string? DESSEC { get; set; } // [DESSEC] VARCHAR(20) NULL,

        public string? CODEMP { get; set; } // [CODEMP] VARCHAR(5) NULL,

        public string? CODUSUA { get; set; } // [CODUSUA] VARCHAR(20) NULL,

        public string? FECREG { get; set; } // [FECREG] DATETIME NULL,

        public string? FECREGELIM { get; set; } // [FECREGELIM] DATETIME NULL,

        public string? NOMEQUIELIM { get; set; } // [NOMEQUIELIM] VARCHAR(20) NULL,

        public string? NOMUSUAELIM { get; set; } // [NOMUSUAELIM] VARCHAR(30) NULL,

        public string? REGELIM { get; set; } // [REGELIM] VARCHAR(1)  NULL,

        public string? NOMEQUIREG { get; set; } // [NOMEQUIREG] VARCHAR(20) NULL,

        public SeccionModel() { } // CONSTRAINT [PK_SECCION] PRIMARY KEY CLUSTERED ([CODSEC] ASC, [COD_ALMACEN] ASC, [CODSUCURSAL] ASC)
    }
}
