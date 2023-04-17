using Ofimania_Browser_App_Rack_Counter.Data;
using Sybase_Data_Access;
using Sybase_Data_Access.Models;

namespace Ofimania_Browser_App_Rack_Counter.Services
{
    public class RackStockService
    {
        public List<RackStock> RackStocks { get; set; }

        public RackStockService()
        {
            RackStocks = new List<RackStock>();
        }

        public async Task LoadSQLRacks(List<RackMovilModel> sqlRacks)
        {
            RackStocks = new List<RackStock>();

            foreach (var sqlrack in sqlRacks)
            {
                RackStocks.Add(new RackStock(sqlrack.CODRACK, sqlrack.CODRACK));
            }
        }

        public async Task<List<RackStock>> GetRackStocks()
        {
            return await Task.FromResult(RackStocks);
        }

        public async Task<RackStock> GetRacksbyCode(string rackCode)
        {
            return await Task.FromResult(RackStocks.Where(auth => auth.RackCode == rackCode).FirstOrDefault());
        }

    }
}
