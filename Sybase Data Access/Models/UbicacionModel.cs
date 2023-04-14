using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access.Models
{
    public class UbicacionModel // [dbo].[UBICACION]
    {
        // [CODRACK] VARCHAR(4) NOT NULL,
        // [CODPROD] VARCHAR(20) NOT NULL,
        // [NUMPASI] DECIMAL(2) NOT NULL,
        // [ORIGEN] VARCHAR(3) NULL,
        // [CODUSUA] VARCHAR(20) NULL,
        // [FECREG] DATETIME NULL,
        // [FECREGELIM] DATETIME NULL,
        // [NOMEQUIELIM] VARCHAR(20) NULL,
        // [NOMUSUAELIM] VARCHAR(30) NULL,
        // [REGELIM] CHAR(1) NULL,
        // [NOMEQUIREG] VARCHAR(20) NULL,
        // [CODALMACEN] VARCHAR(4) NOT NULL,
        // [SECCION] VARCHAR(4) NOT NULL,
        // [CODSUCURSAL] VARCHAR(4) NULL,
        // [ORDEN] INT NULL,
        // [REFERENCIA] VARCHAR(20) NULL,
        // [ITEM] NUMERIC(15) IDENTITY(1, 1) NOT NULL,
        // [CODIGO] NUMERIC(15) NULL,
        // [CANT_CARAS] INT NULL,
        // [CODITEM] INT NULL,
        public UbicacionModel() { } // CONSTRAINT [UBICACION_X] PRIMARY KEY CLUSTERED ([CODALMACEN] ASC, [SECCION] ASC, [CODRACK] ASC, [NUMPASI] ASC, [CODPROD] ASC, [ITEM] ASC)
    }
}
