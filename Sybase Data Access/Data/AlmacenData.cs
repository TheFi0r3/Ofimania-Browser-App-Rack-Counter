using Sybase_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access.Data
{
    public class AlmacenData : IAlmacenData
    {
        private readonly ISQLDataAccess _db;

        public AlmacenData(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<List<AlmacenModel>> GetStoreNames()
        {
            string sql = "select * from dbo.ALMACEN";

            return _db.LoadData<AlmacenModel, dynamic>(sql, new { });
        }

        public Task<List<AlmacenModel>> GetStoreName(string storeCode)
        {
            string sql = "select DESC_ALMACEN from dbo.ALMACEN where COD_ALMACEN = " + storeCode;

            return _db.LoadData<AlmacenModel, dynamic>(sql, new { });
        }
    }
}
