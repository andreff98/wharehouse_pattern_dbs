using Microsoft.CodeAnalysis.CSharp;
using wharehouse_pattern_dbs.Data.SQLServer;
using wharehouse_pattern_dbs.Models;

namespace wharehouse_pattern_dbs.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly SqlContextDb _sqlContextDb;

        public EmployeeRepository(SqlContextDb sqlContextDb) => _sqlContextDb = sqlContextDb;


        public async Task<Employee> GetEmployee(int? id) => await _sqlContextDb.Employee.FindAsync(id);
    }
}
