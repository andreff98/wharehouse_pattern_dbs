using wharehouse_pattern_dbs.Models;

namespace wharehouse_pattern_dbs.Repositories
{
    public interface IWarehouseFactory
    {
        public Task<Employee> GetEmployee(int? id);
    }
}
