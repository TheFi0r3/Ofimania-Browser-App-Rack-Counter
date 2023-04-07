using Sybase_Data_Access.Models;

namespace Sybase_Data_Access
{
    public interface IProductoData
    {
        Task<List<ProductoModel>> GetProductInfo(string productCode);
    }
}