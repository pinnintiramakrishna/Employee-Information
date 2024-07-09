using Microsoft.EntityFrameworkCore;
using WebApiWithAzure.Models;

namespace WebApiWithAzure.Data
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
