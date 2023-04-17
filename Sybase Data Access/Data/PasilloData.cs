using Sybase_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access.Data
{
    public class PasilloData : IPasilloData
    {
        private readonly ISQLDataAccess _db;

        public PasilloData(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<List<PasilloModel>> GetAsileNames()
        {
            string sql = "select * from dbo.PASILLO";

            return _db.LoadData<PasilloModel, dynamic>(sql, new { });
        }

        public Task<List<PasilloModel>> GetAsileName(string asileCode)
        {
            string sql = "select DESCRIPCION from dbo.PASILLO where NUMPASI = " + asileCode;

            return _db.LoadData<PasilloModel, dynamic>(sql, new { });
        }
    }
}

