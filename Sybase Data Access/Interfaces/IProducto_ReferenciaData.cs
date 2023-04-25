using Sybase_Data_Access.Models;

namespace Sybase_Data_Access.Data
{
    public interface IProducto_ReferenciaData
    {
        Task<List<Producto_ReferenciaModel>> GetBarCode(string prodCode);
        Task<List<Producto_ReferenciaModel>> GetProdCode(string barCode);
    }
}