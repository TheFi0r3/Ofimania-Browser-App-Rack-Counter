namespace BlazorApp_Tutorial.Data
{
    public class RackStockService
    {
        public List<RackStock> RackStocks { get; set; }

        public RackStockService()
        {
            RackStocks = new List<RackStock>();

            RackStocks.Add(new RackStock(452135, "452135"));
            RackStocks.Add(new RackStock(184642, "184642"));
            RackStocks.Add(new RackStock(631232, "631232"));
            RackStocks.Add(new RackStock(761412, "761412"));
        }

        public async Task<List<RackStock>> GetRackStocks()
        {
            return await Task.FromResult(RackStocks);
        }

        public async Task<RackStock> GetRacksbyCode (int rackCode)
        {
            return await Task.FromResult(RackStocks.Where(auth => auth.RackCode == rackCode).FirstOrDefault());
        }

    }
}
