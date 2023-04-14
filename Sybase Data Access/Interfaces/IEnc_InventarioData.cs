using Sybase_Data_Access.Models;

namespace Sybase_Data_Access
{
    public interface IEnc_InventarioData
    {
        Task<List<Enc_InventarioModel>> GetInventoryList(string estate);
    }
}