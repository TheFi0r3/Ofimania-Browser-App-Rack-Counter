using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access.Models
{
    public class RackMovilModel
    {
        public int? CODRACK { get; set; }

        public int? CODPROD { get; set; }

        public int? CODINVENTARIO { get; set; }

        public int? CODSUCURSAL { get; set; }

        public int? CODALMACEN { get; set; }

        public string? CODUSUAC1 { get; set; }

        public string? CODUSAC2 { get; set; }

        public string? CODUSAC3 { get; set; }

        public int? CON1 { get; set; }

        public int? CON2 { get; set; }
        
        public int? CON3 { get; set; }

        public string? FECHA_CONTEO { get; set; }

        public string? FECHA_GENERACION { get; set; }

        public long? REFERENCIA { get; set; }

        public int? TER1 { get; set; }

        public int? TER2 { get; set; }

        public int? TER3 { get; set; }

        public int? MANUAL { get; set; }
        public RackMovilModel() { }
    }
}
