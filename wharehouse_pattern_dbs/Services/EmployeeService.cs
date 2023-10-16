using wharehouse_pattern_dbs.Data.SQLServer;
using wharehouse_pattern_dbs.Models;
using wharehouse_pattern_dbs.Repositories;

namespace wharehouse_pattern_dbs.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IWarehouseFactory _warehouseFactory;

        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository(new SqlContextDb());
            // employeeRepository = WhareHouseFactory.GetEmployeeRepositoryAccessObj();
        }
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            // _warehouseFactory = new IWarehouseFactory();
            // employeeRepository = WhareHouseFactory.GetEmployeeRepositoryAccessObj();
        }

        public async Task<Employee> GetEmployee(int? id) => await _warehouseFactory.GetEmployee(id); // _employeeRepository.GetEmployee(id);
    }
}
