using Ofimania_Browser_App_Rack_Counter.Data;
using Sybase_Data_Access;
using Sybase_Data_Access.Models;

namespace Ofimania_Browser_App_Rack_Counter.Services
{
    public class RackStoreService
    {
        public List<RackStore> RackStores { get; set; }

        public RackStoreService()
        {
            RackStores = new List<RackStore>();
        }

        public async Task LoadSQLStores(List<Enc_InventarioModel> sqlStores)
        {
            RackStores = new List<RackStore>();

            foreach (var sqlstore in sqlStores)
            {
                RackStores.Add(new RackStore(sqlstore.CODINVENTARIO.Value, sqlstore.COD_ALMACEN));
            }
        }

        public async Task<List<RackStore>> GetRackStores()
        {
            return await Task.FromResult(RackStores);
        }


    }
}
