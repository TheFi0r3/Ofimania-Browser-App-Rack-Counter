using Sybase_Data_Access.Models;

namespace Sybase_Data_Access.Data
{
    public interface IAlmacenData
    {
        Task<List<AlmacenModel>> GetStoreNames();

        Task<List<AlmacenModel>> GetStoreName(string storeCode);
    }
}