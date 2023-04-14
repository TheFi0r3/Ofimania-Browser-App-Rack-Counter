using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCore.AseClient;


namespace Sybase_Data_Access
{
    public class SQLDataAccess : ISQLDataAccess
    {
        private readonly IConfiguration _config;

        public string ConnectionString { get; set; }

        public SqlConnection Connection { get; set; }

        // AseConnection
        // SqlConnection

        public SQLDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task SetConnection(string user, string password)
        {
           await Task.FromResult(ConnectionString = "Data Source=DESKTOP-ANTONIO\\SQLEXPRESS; Initial Catalog=SisAdmin; User ID=" + user + "; Password =" + password+ "; TrustServerCertificate=true");
//           await Task.FromResult(ConnectionString = "Data Source='VALENCIA2';Port=5000;Database='SisAdmin';UID='" + user + "';PWD='" + password + "';Charset=iso_1");
        }

        public async Task<bool> CheckConnection()
        {
            var ConnState = true;

            try
            {
                Connection = new SqlConnection(ConnectionString);
                Connection.Open();
            }
            catch (Exception) 
            {
                ConnState = false;
            }
            finally
            {
                Connection.Close();
            }

            return await Task.FromResult(ConnState);
        }

        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            //string connectionString = _config.GetConnectionString(ConnectionString);
            string connectionString = ConnectionString;

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var data = await connection.QueryAsync<T>(sql, parameters);

                return data.ToList();
            }
        }

        public async Task SaveData<T>(string sql, T parameters)
        {
            //string connectionString = _config.GetConnectionString(ConnectionString);
            string connectionString = ConnectionString;

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}
