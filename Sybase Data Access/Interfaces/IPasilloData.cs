using Sybase_Data_Access.Models;

namespace Sybase_Data_Access.Data
{
    public interface IPasilloData
    {
        Task<List<PasilloModel>> GetAsileName(string asileCode);

        Task<List<PasilloModel>> GetAsileNames();
    }
}