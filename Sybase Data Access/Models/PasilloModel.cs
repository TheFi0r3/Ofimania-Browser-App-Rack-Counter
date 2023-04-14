using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access.Models
{
    public class PasilloModel // [dbo].[PASILLO]
    {
        public float DECIMAL { get; set; } // [NUMPASI] DECIMAL (10) NOT NULL,

        // [DESCRIPCION] VARCHAR (250) NOT NULL,

        // [REGELIM] VARCHAR (1) DEFAULT ('N') NULL,

        public PasilloModel() { } // CONSTRAINT [PASILLO_1955808041] PRIMARY KEY CLUSTERED ([NUMPASI] ASC)
    }
}
