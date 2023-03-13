namespace BlazorApp_Tutorial.Data
{
    public class ItemsTableService
    {
        private static readonly string[] Summaries = new[]
{
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public Task<ItemsTable[]> GetTableAsync()
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new ItemsTable
            {
                ItemNumb = Random.Shared.Next(0, 1000),
                ItemCode = Summaries[Random.Shared.Next(Summaries.Length)],
                ItemName = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }


    }
}

 