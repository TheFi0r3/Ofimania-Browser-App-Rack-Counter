using Sybase_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access.Data
{
    public class Producto_ReferenciaData : IProducto_ReferenciaData
    {
        private readonly ISQLDataAccess _db;

        public Producto_ReferenciaData(ISQLDataAccess db)
        {
            _db = db;
        }
        public Task<List<Producto_ReferenciaModel>> GetProdCode(string barCode)
        {
            string sql = "select distinct CODPROD from dbo.PRODUCTO_REFERENCIA where COD_REFERENCIA = '" + barCode + "'";

            return _db.LoadData<Producto_ReferenciaModel, dynamic>(sql, new { });
        }

        public Task<List<Producto_ReferenciaModel>> GetBarCode(string prodCode)
        {
            string sql = "select distinct COD_REFERENCIA from dbo.PRODUCTO_REFERENCIA where CODPROD = '" + prodCode + "'";

            return _db.LoadData<Producto_ReferenciaModel, dynamic>(sql, new { });
        }
    }
}
