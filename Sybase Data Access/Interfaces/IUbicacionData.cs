using Sybase_Data_Access.Models;

namespace Sybase_Data_Access.Data
{
    public interface IUbicacionData
    {
        Task<List<UbicacionModel>> GetAll();

        Task<List<UbicacionModel>> GetLocationCodes(string rackCode);
    }
}