using Sybase_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access
{
    public class ProductoData : IProductoData
    {
        private readonly ISQLDataAccess _db;

        public ProductoData(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<List<ProductoModel>> GetProductInfo(string productCode)
        {
            string sql = "select * from dbo.PRODUCTO where CODPROD = " + productCode;

            return _db.LoadData<ProductoModel, dynamic>(sql, new { });
        }
    }
}
