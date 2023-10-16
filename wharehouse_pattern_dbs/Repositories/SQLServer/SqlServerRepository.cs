using wharehouse_pattern_dbs.Data.PostgreSQL;
using wharehouse_pattern_dbs.Data.SQLServer;
using wharehouse_pattern_dbs.Models;

namespace wharehouse_pattern_dbs.Repositories.SQLServer
{
    public class SqlServerRepository : ISqlServerRepository
    {
        private readonly SqlContextDb _sqlContextDb;

        public SqlServerRepository(SqlContextDb sqlContextDb) => _sqlContextDb = sqlContextDb;

        public async Task<Employee> GetEmployee(int? id) => await _sqlContextDb.Employee.FindAsync(id);
    }
}
