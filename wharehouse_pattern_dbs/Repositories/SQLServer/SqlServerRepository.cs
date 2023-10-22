using Microsoft.EntityFrameworkCore;
using wharehouse_pattern_dbs.Data.PostgreSQL;
using wharehouse_pattern_dbs.Data.SQLServer;
using wharehouse_pattern_dbs.Models;

namespace wharehouse_pattern_dbs.Repositories.SQLServer
{
    public class SqlServerRepository : IEmployeeRepository
    {
        private readonly SqlContextDb _sqlContextDb;

        public SqlServerRepository(SqlContextDb sqlContextDb) => _sqlContextDb = sqlContextDb;

        public async Task<Employee> GetEmployee(int? id) => await _sqlContextDb.Employee.FindAsync(id);

        public async Task<IList<Employee>> GetEmployeesList() => await _sqlContextDb.Employee.ToListAsync();

        public async Task Update(Employee employee)
        {
            _sqlContextDb.Update(employee);
            await _sqlContextDb.SaveChangesAsync();
        }

        public async Task Add(Employee employee)
        {
            _sqlContextDb.Add(employee);
            await _sqlContextDb.SaveChangesAsync();
        }
        public async Task Delete(Employee employee)
        {
            _sqlContextDb.Employee.Remove(employee);
            await _sqlContextDb.SaveChangesAsync();
        }

        public bool EmployeeExists(int id) => (_sqlContextDb.Employee?.Any(e => e.EmployeeID == id)).GetValueOrDefault();
    }
}
