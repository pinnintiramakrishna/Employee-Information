using Microsoft.EntityFrameworkCore;
using WebApiWithAzure.Models;
using System.Linq;

namespace WebApiWithAzure.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDBContext _dbContext;
        public EmployeeRepository(EmployeeDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return  await _dbContext.Employees.ToListAsync<Employee>();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _dbContext.Employees.Where(e => e.Id == id).FirstOrDefaultAsync();
        }
    }
}
