using Sybase_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access.Data
{
    public class SeccionData : ISeccionData
    {
        private readonly ISQLDataAccess _db;

        public SeccionData(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<List<SeccionModel>> GetSeccionNames()
        {
            string sql = "select * from dbo.SECCION";

            return _db.LoadData<SeccionModel, dynamic>(sql, new { });
        }

        public Task<List<SeccionModel>> GetSeccionName(string seccionCode)
        {
            string sql = "select DESSEC from dbo.SECCION where CODSEC = '" + seccionCode + "'";

            return _db.LoadData<SeccionModel, dynamic>(sql, new { });
        }
    }
}
