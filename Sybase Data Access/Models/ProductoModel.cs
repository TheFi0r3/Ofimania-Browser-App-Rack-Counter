using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access.Models
{
    public class ProductoModel
    {
        public int? CODPROD { get; set; }

        public int? CODGRUPO { get; set; }

        public int? CODSUBGRUPO { get; set; }

        public int? CODMAR { get; set; }

        public int? CODTEMPORADA { get; set; }

        public int? COD_UNIDAD { get; set; }

        public string? DESPROD { get; set; }

        public string? NOMCORTO { get; set; }

        public string? TIPOPROD { get; set; }

        public float? IMPCOM { get; set; }

        public float? IMPVEN { get; set; }

        public int? EXENTO { get; set; }

        public string? SERIALES { get; set; }

        public string? APLIDESCADM { get; set; }

        public string? APLIDESCPOS { get; set; }

        public string? ESTADOPOS { get; set; }

        public string? ESTADOADM { get; set; }

        public int? CANTEMPAQ { get; set; }

        public string? PROD_ORIGEN { get; set; }

        public int? CANTIDAD_DIV { get; set; }

        public int? CANTIDAD_MULT { get; set; }

        public string? IN_INVENTARIO { get; set; }

        public string? CODUSUA { get; set; }

        public string? FECREG { get; set; }

        public string? FECREGELIM { get; set; }

        public string? NOMEQUIELIM { get; set; }

        public string? NOMUSUAELIM { get; set; }

        public string? REGELIM { get; set; }

        public string? NOMEQUIREG { get; set; }

        public string? NOMLISPREC { get; set; }

        public string? FOTO { get; set; }

        public string? GUIASABER { get; set; }

        public string? COD_CPE { get; set; }

        public string? COD_REFERENCIA { get; set; }

        public string? FECHA_CPE { get; set; }

        public string? FACTOR { get; set; }

        public string? IND_NUEVO { get; set; }

        public string? AUTOR { get; set; }

        public string? FECHA_PRECIO { get; set; }

        public string? LISTA_PRECIO { get; set; }

        public string? GRUPO_LISTA_PRECIO { get; set; }

        public string? NOMBRE_LISTA_PRECIO { get; set; }

        public string? MIN_MAX { get; set; }

        public string? FECHA_MODIFICA { get; set; }

        public string? USUARIO_MOD { get; set; }

        public string? EQUIPO_MOD { get; set; }

        public int? IND_VARIANTE { get; set; }

        public string? DESCPOS { get; set; }

        public string? CODPROD2 { get; set; }

        public float? DIVIDE { get; set; }

        public float? MULTIPLICA { get; set; }

        public string? CENTRAL { get; set; }

        public bool COD_SENCAMER { get; set; }

        public int IND_ACT { get; set; }

        public string? COMP_ACT { get; set; }

        public string? REQ_ACT { get; set; }

        public string? CODCLASE { get; set; }

        public string? CODSUBCLASE { get; set; }

        public string? PROD_UNIFICADO { get; set; }

        public int? ORDEN_LISTA_PRECIO { get; set; }

        public ProductoModel() { }
    }
}
