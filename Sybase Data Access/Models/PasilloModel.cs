using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access.Models
{
    public class PasilloModel // [dbo].[PASILLO]
    {
        public decimal DECIMAL { get; set; } // [NUMPASI] DECIMAL (10) NOT NULL,
        public string? DESCRIPCION { get; set; } // [DESCRIPCION] VARCHAR (250) NOT NULL,
        public string? REGELIM { get; set; } // [REGELIM] VARCHAR (1) DEFAULT ('N') NULL,
        public PasilloModel() { } // CONSTRAINT [PASILLO_1955808041] PRIMARY KEY CLUSTERED ([NUMPASI] ASC)
    }
}
