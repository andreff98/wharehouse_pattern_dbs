using wharehouse_pattern_dbs.Data.SQLServer;
using wharehouse_pattern_dbs.Models;
using wharehouse_pattern_dbs.Repositories;
using wharehouse_pattern_dbs.Repositories.PostgreSQL;
using wharehouse_pattern_dbs.Repositories.SQLServer;

namespace wharehouse_pattern_dbs.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> GetEmployee(int? id)
        {
            return await _employeeRepository.GetEmployee(id); 
        }
    }
}
