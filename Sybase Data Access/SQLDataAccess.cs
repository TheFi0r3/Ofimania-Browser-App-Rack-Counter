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

        public async Task<string> SetServerAddress()
        {
            string line;

            try
            {
                StreamReader sr = new StreamReader("wwwroot\\ini\\Server.ini"); //Pass the file path and file name to the StreamReader constructor
                                      //Read the first line of text
                line = sr.ReadLine(); //[database]
                line = sr.ReadLine(); //DBMS = "SYC Adaptive Server Enterprise"
                line = sr.ReadLine(); //DATABASE = "SisAdmin"
                line = sr.ReadLine();

                while (line != null)  //Continue to read until you reach end of file
                {
                    if (line.Contains("SERVER")) 
                    {
                        if (line.Contains("--"))
                        {
                            line = sr.ReadLine();
                            continue;
                        }

                        line = line.Remove(0, 10);
                        line = line.Trim(new Char[] { '"', '\\' });

                        sr.Close(); //close the file

                        return await Task.FromResult(line);
                    }

                    line = sr.ReadLine();
                    continue;
                }

                sr.Close(); //close the file
            }
            catch (Exception e)
            {
                return await Task.FromResult("ERROR: " + e.Message);
            }

            return await Task.FromResult("ERROR: No se encuentra servidor");
        }

        public async Task SetConnection(string user, string password,string server)
        {
            await Task.FromResult(ConnectionString = "Data Source=DESKTOP-ANTONIO\\SQLEXPRESS; Initial Catalog=SisAdmin; User ID=" + user + "; Password =" + password+ "; TrustServerCertificate=true");
//            await Task.FromResult(ConnectionString = "Data Source='" + server + "';Port=5000;Database='SisAdmin';UID='" + user + "';PWD='" + password + "';Charset=iso_1");
        }

        public async Task<bool> CheckConnection()
        {
            var ConnState = true;

            try
            {
                Connection = new SqlConnection(ConnectionString);
                Connection.Open();
                Connection.Close();
            }
            catch (Exception) 
            {
                ConnState = false;
            }

            return await Task.FromResult(ConnState);
        }

        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            string connectionString = ConnectionString; //string connectionString = _config.GetConnectionString(ConnectionString);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var data = await connection.QueryAsync<T>(sql, parameters);

                return data.ToList();
            }
        }

        public async Task SaveData<T>(string sql, T parameters)
        {
            string connectionString = ConnectionString; //string connectionString = _config.GetConnectionString(ConnectionString);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}
