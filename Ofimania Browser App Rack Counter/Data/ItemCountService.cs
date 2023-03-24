namespace Ofimania_Browser_App_Rack_Counter.Data
{
    public class ItemCountService
    {
        public List<ItemRack> ItemsCount { get; set; }

        public ItemCountService()
        {
            //throw new Exception("AuthorServiceException");
            ItemsCount = new List<ItemRack>();

        }

        public async Task<List<ItemRack>> GetItemsRack()
        {
            return await Task.FromResult(ItemsCount);
        }

        public async Task<ItemRack> GetItemsByCode(long itemCode)
        {
            return await Task.FromResult(ItemsCount.Where(auth => auth.ItemCode == itemCode).FirstOrDefault());
        }

        public async Task<bool> SaveItemRack(ItemRack itemRack)
        {
            //author.AuthorId = GetNewAuthor();
            foreach (var rackItem in ItemsCount)
                if (rackItem.ItemCode == itemRack.ItemCode)
                {
                    rackItem.ItemNumb = itemRack.ItemNumb;
                    return await Task.FromResult(true);
                }
            
            ItemsCount.Add(itemRack);
            return await Task.FromResult(true);
        }

        public async Task<bool> CheckItemByCode(int itemCode)
        {
            return await Task.FromResult(true);
        }

    }
}
