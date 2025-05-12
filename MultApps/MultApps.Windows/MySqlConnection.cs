using System.Data;

namespace MultApps.Models.Repositories
{
    internal class MySqlConnection : IDbConnection
    {
        private string connectionString;

        public MySqlConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}