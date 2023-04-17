using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Sybase_Data_Access.Models
{
    public class ProductoModel // [dbo].[PRODUCTO]
    {
        public string? CODPROD { get; set; } // [CODPROD] VARCHAR(20) NOT NULL,
        public string? CODGRUPO { get; set; } // [CODGRUPO] VARCHAR(4) NULL,
        public string? CODSUBGRUPO { get; set; } // [CODSUBGRUPO] VARCHAR(4) NULL,
        public string? CODMAR { get; set; } // [CODMAR] VARCHAR(4) NULL,
        public string? CODTEMPORADA { get; set; } // [CODTEMPORADA] VARCHAR(4) NULL,
        public int? COD_UNIDAD { get; set; } // [COD_UNIDAD] INT NULL,
        public string? DESPROD { get; set; } // [DESPROD] VARCHAR(60) NOT NULL,
        public string? NOMCORTO { get; set; } // [NOMCORTO] VARCHAR(50) NULL,
        public string? TIPOPROD { get; set; } // [TIPOPROD] CHAR(1) NULL,
        public float? IMPCOM { get; set; } // [IMPCOMP] NUMERIC(5, 2) NULL,
        public float? IMPVEN { get; set; } // [IMPVEN] NUMERIC(5, 2) NULL,
        public int? EXENTO { get; set; } // [EXENTO] CHAR(1) NULL,
        public string? SERIALES { get; set; } // [SERIALES] CHAR(1) NULL,
        public string? APLIDESCADM { get; set; } // [APLIDESCADM] CHAR(1) NULL,
        public string? APLIDESCPOS { get; set; } // [APLIDESCPOS] CHAR(1) NULL,
        public string? ESTADOPOS { get; set; } // [ESTADOPOS] CHAR(1) NULL,
        public string? ESTADOADM { get; set; } // [ESTADOADM] CHAR(1) NULL,
        public int? CANTEMPAQ { get; set; } // [CANTEMPAQ] NUMERIC(10) NULL,
        public string? PROD_ORIGEN { get; set; } // [PROD_ORIGEN] VARCHAR(20) NULL,
        public int? CANTIDAD_DIV { get; set; } // [CANTIDAD_DIV] INT NULL,
        public int? CANTIDAD_MULT { get; set; } // [CANTIDAD_MULT] INT NULL,
        public string? IN_INVENTARIO { get; set; } // [IN_INVENTARIO] CHAR(1) NULL,
        public string? CODUSUA { get; set; } // [CODUSUA] VARCHAR(20) NULL,
        public string? FECREG { get; set; } // [FECREG] DATETIME NULL,
        public string? FECREGELIM { get; set; } // [FECREGELIM] DATETIME NULL,
        public string? NOMEQUIELIM { get; set; } // [NOMEQUIELIM] VARCHAR(20) NULL,
        public string? NOMUSUAELIM { get; set; } // [NOMUSUAELIM] VARCHAR(30) NULL,
        public string? REGELIM { get; set; } // [REGELIM] CHAR(1) NULL,
        public string? NOMEQUIREG { get; set; } // [NOMEQUIREG] VARCHAR(20) NULL,
        public string? NOMLISPREC { get; set; } // [NOMLISPREC] VARCHAR(100) NULL,
        public string? FOTO { get; set; } // [FOTO] VARCHAR(50) NULL,
        public string? GUIASABER { get; set; } // [GUIASABER] TEXT NULL,
        public string? COD_CPE { get; set; } // [COD_CPE] VARCHAR(20) NULL,
        public string? COD_REFERENCIA { get; set; } // [COD_REFERENCIA] VARCHAR(20) NULL,
        public string? FECHA_CPE { get; set; } // [FECHA_CPE] DATE NULL,
        public string? FACTOR { get; set; } // [FACTOR] VARCHAR(1) NULL,
        public string? IND_NUEVO { get; set; } // [IND_NUEVO] CHAR(1) DEFAULT('S') NULL,
        public string? AUTOR { get; set; } // [AUTOR] VARCHAR(50) NULL,
        public string? FECHA_PRECIO { get; set; } // [FECHA_PRECIO] DATETIME NULL,
        public string? LISTA_PRECIO { get; set; } // [LISTA_PRECIO] VARCHAR(1) NULL,
        public string? GRUPO_LISTA_PRECIO { get; set; } // [GRUPO_LISTA_PRECIO] VARCHAR(4) NULL,
        public string? NOMBRE_LISTA_PRECIO { get; set; } // [NOMBRE_LISTA_PRECIO] VARCHAR(50) NULL,
        public string? MIN_MAX { get; set; } // [MIN_MAX] CHAR(1) NULL,
        public string? FECHA_MODIFICA { get; set; } // [FECHA_MODIFICA] DATE NULL,
        public string? USUARIO_MOD { get; set; } // [USUARIO_MOD] VARCHAR(30) NULL,
        public string? EQUIPO_MOD { get; set; } // [EQUIPO_MOD] VARCHAR(20) NULL,
        public int? IND_VARIANTE { get; set; } // [IND_VARIANTE] NUMERIC(1) NULL,
        public string? DESCPOS { get; set; } // [DESCPOS] VARCHAR(1) NULL,
        public string? CODPROD2 { get; set; } // [CODPROD2] VARCHAR(20) NULL,
        public float? DIVIDE { get; set; } // [DIVIDE] NUMERIC(10) NULL,
        public float? MULTIPLICA { get; set; } // [MULTIPLICA] NUMERIC(10) NULL,
        public string? CENTRAL { get; set; } // [CENTRAL] VARCHAR(1) NULL,
        public bool COD_SENCAMER { get; set; } // [COD_SENCAMER] BIT DEFAULT((0)) NOT NULL,
        public int IND_ACT { get; set; } // [IND_ACT] INT DEFAULT((0)) NOT NULL,
        public string? COMP_ACT { get; set; } // [COMP_ACT] VARCHAR(1) NULL,
        public string? REQ_ACT { get; set; } // [REQ_ACT] VARCHAR(1) NULL,
        public string? CODCLASE { get; set; } // [CODCLASE] VARCHAR(4) NULL,
        public string? CODSUBCLASE { get; set; } // [CODSUBCLASE] VARCHAR(4) NULL,
        public string? PROD_UNIFICADO { get; set; } // [PROD_UNIFICADO] VARCHAR(1) DEFAULT('N') NULL,
        public int? ORDEN_LISTA_PRECIO { get; set; } // [ORDEN_LISTA_PRECIO] INT DEFAULT((0)) NULL,
        public ProductoModel() { } // CONSTRAINT [PRODUCTO_3603853221] PRIMARY KEY CLUSTERED ([CODPROD] ASC)
    }
}
