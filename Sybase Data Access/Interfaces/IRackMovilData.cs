using Sybase_Data_Access.Models;

namespace Sybase_Data_Access
{
    public interface IRackMovilData
    {
        Task<List<RackMovilModel>> GetRackList();

        Task<List<RackMovilModel>> GetRackList(string userName, string countNumb, string storeCode);

        Task<List<RackMovilModel>> GetRackList(string userName, string countNumb);

        Task<List<RackMovilModel>> GetProductList(string rackCode);
    }
}