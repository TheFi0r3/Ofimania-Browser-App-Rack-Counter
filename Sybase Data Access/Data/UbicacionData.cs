using Sybase_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access.Data
{
    public class UbicacionData : IUbicacionData
    {
        private readonly ISQLDataAccess _db;

        public UbicacionData(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<List<UbicacionModel>> GetAll()
        {
            string sql = "select * from dbo.UBICACION";

            return _db.LoadData<UbicacionModel, dynamic>(sql, new { });
        }

        public Task<List<UbicacionModel>> GetLocationCodes(string rackCode)
        {
            string sql = "select distinct CODRACK, NUMPASI, SECCION, CODALMACEN from dbo.UBICACION where CODRACK = " + rackCode;

            return _db.LoadData<UbicacionModel, dynamic>(sql, new { });
        }
    }
}
