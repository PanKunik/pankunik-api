using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace WebAPI.Infrastructure.SqlDataAccess.Internal
{
    internal class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionName;

        public SqlDataAccess(IConfiguration configuration, string connectionName)
        {
            _configuration = configuration;
            _connectionName = connectionName;
        }

        protected string GetConnectionString(string connectionName)
        {
            return _configuration.GetConnectionString(connectionName);
        }

        public async Task<IEnumerable<TResponse>> LoadDataAsync<TResponse, dynamic>(string sql, dynamic parameters)
        {
            var connectionString = GetConnectionString(_connectionName);
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            return await connection.QueryAsync<TResponse>(sql, parameters);
        }

        public async Task<TResponse> LoadFirstOrDefaultAsync<TResponse, dynamic>(string sql, dynamic parameters)
        {
            var connectionString = GetConnectionString(_connectionName);
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            return await connection.QueryFirstOrDefaultAsync<TResponse>(sql, parameters);
        }
    }
}