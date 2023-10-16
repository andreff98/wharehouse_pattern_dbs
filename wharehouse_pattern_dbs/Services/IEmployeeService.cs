using wharehouse_pattern_dbs.Models;

namespace wharehouse_pattern_dbs.Services
{
    public interface IEmployeeService
    {
        public Task<Employee> GetEmployee(int? id);
    }
}
