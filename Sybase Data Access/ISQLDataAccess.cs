namespace Sybase_Data_Access
{
    public interface ISQLDataAccess
    {
        string ConnectionString { get; set; }

        Task<string> SetServerAddress();

        Task SetConnection(string user, string password, string server);

        Task<bool> CheckConnection();

        Task<List<T>> LoadData<T, U>(string sql, U parameters);

        Task SaveData<T>(string sql, T parameters);
    }
}