using Sybase_Data_Access.Models;

namespace Sybase_Data_Access.Data
{
    public interface ISeccionData
    {
        Task<List<SeccionModel>> GetSeccionName(string seccionCode);

        Task<List<SeccionModel>> GetSeccionNames();
    }
}