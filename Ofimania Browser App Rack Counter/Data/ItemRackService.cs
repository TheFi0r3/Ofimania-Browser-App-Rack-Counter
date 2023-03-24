namespace Ofimania_Browser_App_Rack_Counter.Data
{
    public class ItemRackService
    {
        public List<ItemRack> ItemsRack { get; set; }

        public ItemRackService()
        {
            //throw new Exception("AuthorServiceException");
            ItemsRack = new List<ItemRack>();

            ItemsRack.Add(new ItemRack(31231241, "Lapices Mongol", 122));
            ItemsRack.Add(new ItemRack(81621141, "Borradores Nata", 22));
            ItemsRack.Add(new ItemRack(73142441, "Cuadernos Andes", 33));
            ItemsRack.Add(new ItemRack(22342241, "Boligafros Bic", 31));
            ItemsRack.Add(new ItemRack(37564741, "Hojas Blancas Carta", 2));
            ItemsRack.Add(new ItemRack(14562451, "Cinta Plastica", 13));

        }

        public async Task<List<ItemRack>> GetItemsRack()
        {
            return await Task.FromResult(ItemsRack);
        }

        public async Task<ItemRack> GetItemsByCode(long itemCode)
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

 