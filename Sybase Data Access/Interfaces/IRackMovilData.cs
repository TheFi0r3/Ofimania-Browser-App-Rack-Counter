using Sybase_Data_Access.Models;

namespace Sybase_Data_Access
{
    public interface IRackMovilData
    {
        Task<List<RackMovilModel>> GetRackList();

        Task<List<RackMovilModel>> CheckRackList(string userName, string countNumb, string rackCode);

        Task<List<RackMovilModel>> GetRackList(string userName, string countNumb, string storeCode);

        Task<List<RackMovilModel>> GetRackList(string userName, string countNumb);

        Task<List<RackMovilModel>> GetProductList(string rackCode, string userName, string countNumb);

        Task<List<RackMovilModel>> GetProductData(string rackCode, string productCode);

        Task<List<int>> GetProductCount(string rackCode, string productCode, string countNumb);

        Task UpdateRackMovil(string countNumb, string countProd, string rackCode, string prodCode);

        Task InsertRackMovil(string countNumb, string countProd, string rackCode, string prodCode, string SucCode, string storeCode, string userName, string barCode);
    }
}