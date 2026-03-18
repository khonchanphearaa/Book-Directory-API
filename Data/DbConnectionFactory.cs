using System;
using MySqlConnector;
using System.Data;

namespace BooksDirectoryAPI.Data
{
    using MySqlConnector;
    using System.Data;

    public class DbConnectionFactory
    {
        private readonly string? _connectionString;

        public DbConnectionFactory(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateConnection()
            => new MySqlConnection(_connectionString);
    }
}
