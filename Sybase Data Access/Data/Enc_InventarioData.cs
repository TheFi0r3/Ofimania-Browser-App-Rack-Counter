using Sybase_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sybase_Data_Access
{
    public class Enc_InventarioData : IEnc_InventarioData
    {
        private readonly ISQLDataAccess _db;

        public Enc_InventarioData(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<List<Enc_InventarioModel>> GetInventoryList(string estate)
        {
            string sql = "select CODINVENTARIO,COD_ALMACEN from dbo.ENC_INVENTARIO where ESTADO = '" + estate + "'";

            return _db.LoadData<Enc_InventarioModel, dynamic>(sql, new { });
        }

    }
}
