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
            string sql = "select * from dbo.RACKMOVIL group by CODRACK";

            return _db.LoadData<RackMovilModel, dynamic>(sql, new { });
        }

        public Task<List<RackMovilModel>> GetRackList(string userName, string countNumb, string storeCode)
        {
            string sql = "select distinct CODRACK from dbo.RACKMOVIL where CODUSUAC" + countNumb + " = '" + userName + "'  and CODALMACEN = '" + storeCode + "'";

            return _db.LoadData<RackMovilModel, dynamic>(sql, new { });
        }

        public Task<List<RackMovilModel>> GetRackList(string userName, string countNumb)
        {
            string sql = "select distinct CODRACK from dbo.RACKMOVIL where CODUSUAC" + countNumb + " = '" + userName +  "'";

            return _db.LoadData<RackMovilModel, dynamic>(sql, new { });
        }

        public Task<List<RackMovilModel>> GetProductList(string rackCode)
        {
            string sql = "select * from dbo.RACKMOVIL where CODRACK = '" + rackCode + "'";

            return _db.LoadData<RackMovilModel, dynamic>(sql, new { });
        }

    }
}
