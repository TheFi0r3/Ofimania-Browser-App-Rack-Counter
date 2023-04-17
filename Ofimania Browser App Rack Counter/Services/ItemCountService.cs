using Ofimania_Browser_App_Rack_Counter.Data;
using Sybase_Data_Access;
using Sybase_Data_Access.Models;

namespace Ofimania_Browser_App_Rack_Counter.Services
{
    public class ItemCountService
    {
        public List<ItemRack> ItemsCount { get; set; }

        public ItemCountService()
        {
            //throw new Exception("AuthorServiceException");
            ItemsCount = new List<ItemRack>();
        }

        public async Task LoadSQLProduct(List<ProductoModel> sqlProducts)
        {
            foreach (var sqlproduct in sqlProducts)
            {
                ItemsCount.Add(new ItemRack(sqlproduct.CODPROD, sqlproduct.DESPROD, 0));
            }
        }

        public async Task<List<ItemRack>> GetItemsRack()
        {
            return await Task.FromResult(ItemsCount);
        }

        public async Task<ItemRack> GetItemsByCode(string itemCode)
        {
            return await Task.FromResult(ItemsCount.Where(auth => auth.ItemCode == itemCode).FirstOrDefault());
        }

        public async Task<bool> SaveItemRack(ItemRack itemRack)
        {
            if (itemRack.ItemCode == null) return await Task.FromResult(false);

            //author.AuthorId = GetNewAuthor();
            foreach (var rackItem in ItemsCount) {
                if (rackItem.ItemCode == itemRack.ItemCode)
                {
                    rackItem.ItemNumb = itemRack.ItemNumb;
                    return await Task.FromResult(true);
                }
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
