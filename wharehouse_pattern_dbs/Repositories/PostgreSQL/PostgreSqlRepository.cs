using Microsoft.EntityFrameworkCore;
using wharehouse_pattern_dbs.Data.PostgreSQL;
using wharehouse_pattern_dbs.Data.SQLServer;
using wharehouse_pattern_dbs.Models;

namespace wharehouse_pattern_dbs.Repositories.PostgreSQL
{
    public class PostgreSqlRepository : IEmployeeRepository
    {
        private readonly PostgreSqlContextDb _postgreSqlContextDb;

        public PostgreSqlRepository(PostgreSqlContextDb sqlContextDb) => _postgreSqlContextDb = sqlContextDb;

        public async Task<Employee> GetEmployee(int? id) => await _postgreSqlContextDb.Employees.FindAsync(id);

        public async Task<IList<Employee>> GetEmployeesList() => await _postgreSqlContextDb.Employees.ToListAsync();

        public async Task Update(Employee employee)
        {
            _postgreSqlContextDb.Update(employee);
            await _postgreSqlContextDb.SaveChangesAsync();
        }

        public async Task Add(Employee employee)
        {
            _postgreSqlContextDb.Add(employee);
            await _postgreSqlContextDb.SaveChangesAsync();
        }
        public async Task Delete(Employee employee)
        {
            _postgreSqlContextDb.Employees.Remove(employee);
            await _postgreSqlContextDb.SaveChangesAsync();
        }
        public bool EmployeeExists(int id) => (_postgreSqlContextDb.Employees?.Any(e => e.EmployeeID == id)).GetValueOrDefault();
    }
}
