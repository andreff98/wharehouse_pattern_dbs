using wharehouse_pattern_dbs.Models;

namespace wharehouse_pattern_dbs.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<Employee> GetEmployee(int? id);
    }
}
