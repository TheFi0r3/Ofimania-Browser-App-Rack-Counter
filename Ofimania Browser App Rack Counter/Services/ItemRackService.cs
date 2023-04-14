using Ofimania_Browser_App_Rack_Counter.Data;
using Sybase_Data_Access;
using Sybase_Data_Access.Models;

namespace Ofimania_Browser_App_Rack_Counter.Services
{
    public class ItemRackService
    {
        public List<ItemRack> ItemsRack { get; set; }

        public ItemRackService()
        {
            //throw new Exception("AuthorServiceException");
            ItemsRack = new List<ItemRack>();
        }

        public async Task LoadSQLProduct(List<ProductoModel> sqlProducts)
        {
            foreach (var sqlproduct in sqlProducts)
            {
                ItemsRack.Add(new ItemRack(sqlproduct.CODPROD, sqlproduct.DESPROD, 0));
            }
        }

        public async Task<List<ItemRack>> GetItemsRack()
        {
            return await Task.FromResult(ItemsRack);
        }

        public async Task<ItemRack> GetItemsByCode(string itemCode)
        {
            return await Task.FromResult(ItemsRack.Where(auth => auth.ItemCode == itemCode).FirstOrDefault());
        }

        public async Task<bool> SaveItemRack(ItemRack itemRack)
        {
            //author.AuthorId = GetNewAuthor();
            ItemsRack.Add(itemRack);
            return await Task.FromResult(true);
        }

    }
}

