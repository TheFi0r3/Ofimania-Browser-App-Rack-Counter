namespace BlazorApp_Tutorial.Data
{
    public class ItemsRackService
    {
        private static readonly string[] Summaries = new[]
{
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public Task<ItemsRack[]> GetRackAsync()
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new ItemsRack
            {
                ItemNumb = Random.Shared.Next(0, 1000),
                ItemCode = Summaries[Random.Shared.Next(Summaries.Length)],
                ItemName = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }


    }
}

 