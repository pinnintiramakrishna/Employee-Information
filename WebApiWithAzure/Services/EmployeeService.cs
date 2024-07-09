using WebApiWithAzure.Data;
using WebApiWithAzure.Models;

namespace WebApiWithAzure.Services
{
    public class EmployeeService: IEmployeeService
    {
        private IEmployeeRepository _repository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _repository = employeeRepository;
        }

        public Task<IEnumerable<Employee>> GetAllEmployees()
        {
           return _repository.GetAllEmployees();
        }

        public Task<Employee> GetEmployeeById(int id)
        {
            return _repository.GetEmployeeById(id);
        }
    }
}
