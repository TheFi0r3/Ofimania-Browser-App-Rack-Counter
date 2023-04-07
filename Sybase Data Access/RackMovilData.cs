using Sybase_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access
{
    public class RackMovilData : IRackMovilData
    {
        private readonly ISQLDataAccess _db;
        public RackMovilData(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<List<RackMovilModel>> GetRackList()
        {
            string sql = "select distinct CODRACK from dbo.RACKMOVIL";

            return _db.LoadData<RackMovilModel, dynamic>(sql, new { });
        }

        public Task<List<RackMovilModel>> GetRackList(string user, string count)
        {
            string sql = "select distinct CODRACK from dbo.RACKMOVIL where CODUSUAC"+count+" = '"+user+"'";

            return _db.LoadData<RackMovilModel, dynamic>(sql, new { });
        }

        public Task<List<RackMovilModel>> GetProductList(string rack)
        {
            string sql = "select CODPROD from dbo.RACKMOVIL where CODRACK ='" + rack + "'";

            return _db.LoadData<RackMovilModel, dynamic>(sql, new { });
        }
    }
}
