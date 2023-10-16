using wharehouse_pattern_dbs.Data.PostgreSQL;
using wharehouse_pattern_dbs.Data.SQLServer;
using wharehouse_pattern_dbs.Models;

namespace wharehouse_pattern_dbs.Repositories.PostgreSQL
{
    public class PostgreSqlRepository : IPostgreSqlRepository
    {
        private readonly PostgreSqlContextDb _postgreSqlContextDb;

        public PostgreSqlRepository() { }

        public PostgreSqlRepository(PostgreSqlContextDb sqlContextDb) => _postgreSqlContextDb = sqlContextDb;

        public async Task<Employee> GetEmployee(int? id) => await _postgreSqlContextDb.Employees.FindAsync(id);
    }
}
