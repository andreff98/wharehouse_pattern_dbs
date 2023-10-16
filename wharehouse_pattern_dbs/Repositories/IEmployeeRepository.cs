using wharehouse_pattern_dbs.Models;

namespace wharehouse_pattern_dbs.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<Employee> GetEmployee(int? id);
        public Task<IList<Employee>> GetEmployeesList();
        public Task Update(Employee employee);
        public Task Add(Employee employee);
        public Task Delete(Employee employee);
        public bool EmployeeExists(int id);
    }
}
