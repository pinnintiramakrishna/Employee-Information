using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiWithAzure.Models;
using WebApiWithAzure.Services;

namespace WebApiWithAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _service;
        public EmployeeController(IEmployeeService service) 
        {
            _service = service;

        }

        [HttpGet("AllEmployees")]
        public Task<IEnumerable<Employee>> GetAllEmployees()
        {
          return _service.GetAllEmployees();
        }

        [HttpGet]
        public Task<Employee> GetEmployeeById(int id)
        {
            return _service.GetEmployeeById(id);
        }

    }
}
