using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nexorion.Infrastructure.Database
{
     public class DbFactory
    {
        private readonly string _connectionString;

        public DbFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDatabase GetDatabase()
        {
            var connection = new NpgsqlConnection(_connectionString);
            return new Database(connection, DatabaseType.PostgreSQL);
        }
    }
}