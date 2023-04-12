using Sybase_Data_Access.Models;

namespace Sybase_Data_Access
{
    public interface IRackMovilData
    {
        Task<List<RackMovilModel>> GetRackList();

        Task<List<RackMovilModel>> GetRackList(string user, string count, string store);

        Task<List<RackMovilModel>> GetRackList(string user, string count);

        Task<List<RackMovilModel>> GetProductList(string rack);
    }
}