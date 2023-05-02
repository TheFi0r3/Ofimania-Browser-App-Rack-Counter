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

        public Task<List<RackMovilModel>> CheckRackList(string userName, string countNumb, string rackCode)
        {
            string sql = "select distinct CODRACK from dbo.RACKMOVIL where CODUSUAC" + countNumb + " = '" + userName + "'  and CODRACK = '" + rackCode + "' and TER" + countNumb + "= 0";

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

        public Task<List<RackMovilModel>> GetProductList(string rackCode,string userName, string countNumb)
        {
            string sql = "select CODPROD from dbo.RACKMOVIL where CODRACK = '" + rackCode + "' and CODUSUAC" + countNumb + " = '" + userName + "'";

            return _db.LoadData<RackMovilModel, dynamic>(sql, new { });
        }

        public Task<List<RackMovilModel>> GetProductData(string rackCode, string prodCode) 
        { 
            string sql = "select * from dbo.RACKMOVIL where CODRACK = '" + rackCode + "' and CODPROD = '" + prodCode + "'";

            return _db.LoadData<RackMovilModel, dynamic>(sql, new { });
        }

        public Task<List<int>> GetProductCount(string rackCode, string productCode, string countNumb)
        {
            string sql = "select CON" + countNumb + " from dbo.RackMovil where CODRACK = '" + rackCode + "' and CODPROD = '" + productCode + "'";

            return _db.LoadData<int, dynamic>(sql, new { });
        }

        public Task UpdateRackMovil(string countNumb, string countProd, string rackCode, string prodCode)
        {
            string sql = "update dbo.RACKMOVIL " +
                "set CON" + countNumb + " = " + countProd + ", FECHA_CONTEO = CURRENT_TIMESTAMP, TER" + countNumb + "= 1 " +
                "where CODRACK = '" + rackCode + "' and  CODPROD = '" + prodCode + "'";

            return _db.SaveData(sql, new { });
        }
        public Task InsertRackMovil(string countNumb, string countProd, string rackCode, string prodCode,string SucCode, string storeCode, string userName, string barCode)
        {
            if (barCode == null) barCode = "'NULL'";
            else barCode = "'" + barCode + "'";

            var CODUSAC1 = "NO ASIGNADO";
            var CODUSAC2 = "NO ASIGNADO";
            var CODUSAC3 = "NO ASIGNADO";

            switch (countNumb)
            {
                case "1":
                    CODUSAC1 = userName;
                    break;
                case "2":
                    CODUSAC2 = userName;
                    break;
                case "3":
                    CODUSAC3 = userName;
                    break;
            }

            string sql = "insert into dbo.RACKMOVIL " +
                "(CODRACK, CODPROD, CODINVENTARIO, CODSUCURSAL, CODALMACEN, CODUSUAC1, CODUSUAC2, CODUSUAC3, CON" + countNumb + ", FECHA_CONTEO, FECHA_GENERACION, REFERENCIA, TER"+ countNumb + ") " +
                "values ('"+rackCode+"', '" + prodCode+"', 6, '" + SucCode+"', '" + storeCode+ "', '" + CODUSAC1 + "','" + CODUSAC2 + "','" + CODUSAC3 + "', " + countProd+", CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, "+barCode+", 1)";

            return _db.SaveData(sql, new { });
        }

    }
}
