using WebApiWithAzure.Models;

namespace WebApiWithAzure.Data
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int id);
    }
}
