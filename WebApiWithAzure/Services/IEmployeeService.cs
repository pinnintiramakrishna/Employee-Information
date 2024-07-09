using WebApiWithAzure.Models;

namespace WebApiWithAzure.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllEmployees();

        Task<Employee> GetEmployeeById(int id);
    }
}
