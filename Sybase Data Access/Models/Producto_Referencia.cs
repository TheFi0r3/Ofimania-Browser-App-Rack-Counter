using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access.Models
{
    public class Producto_Referencia // [dbo].[PRODUCTO_REFERENCIA]
    {
        // [COD_REFERENCIA] VARCHAR(20) NOT NULL,

        // [CODPROD] VARCHAR(20) NOT NULL,

        // [CODUSUA] VARCHAR(20) NULL,

        // [FECREG] DATETIME NULL,

        // [FECREGELIM] DATETIME NULL,

        // [NOMEQUIELIM] VARCHAR(20) NULL,

        // [NOMUSUAELIM] VARCHAR(30) NULL,

        // [REGELIM] CHAR(1) NOT NULL,

        // [NOMEQUIREG] VARCHAR(20) NULL,

        // [IND_ACT] INT DEFAULT((0)) NOT NULL,
        public Producto_Referencia() { } // CONSTRAINT [PK_PRODUCTO_REFERENCIA] PRIMARY KEY CLUSTERED ([COD_REFERENCIA] ASC, [CODPROD] ASC, [REGELIM] ASC)
    }
}
