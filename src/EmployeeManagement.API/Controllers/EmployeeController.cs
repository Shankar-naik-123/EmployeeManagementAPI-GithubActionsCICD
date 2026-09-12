using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<EmployeeModel> employees = new List<EmployeeModel>
        {
            new EmployeeModel { Id = Guid.NewGuid(), Name = "John Doe desai", Designation = "Software Engineer", Adresss = "123 Main St", ServiceYears = 5 },
            new EmployeeModel { Id = Guid.NewGuid(), Name = "Jane Smith desai", Designation = "Project Manager", Adresss = "456 Elm St", ServiceYears = 8 },
            new EmployeeModel { Id = Guid.NewGuid(), Name = "Alice Johnson", Designation = "QA Analyst", Adresss = "789 Oak St", ServiceYears = 3 }
        };

        [HttpGet(Name = "GetEmployees")]
        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return employees;
        }


        [HttpPost("add")]
        public IActionResult AddEmployee([FromBody] EmployeeDto newEmployee)
        {
            if (newEmployee == null)
                return BadRequest();
            var employeemodel = new EmployeeModel
            {
                Id = Guid.NewGuid(),
                Name = newEmployee.Name,
                Designation = newEmployee.Designation,
                Adresss = newEmployee.Adresss,
                ServiceYears = newEmployee.ServiceYears,
            };
            employees.Add(employeemodel);

            return Ok("Created!");
            
            
        }

        [HttpGet("/healthcheck")]
        public IActionResult  HealthCheck()
        {
           return  Ok("Sever is healthy!"); 
        }
    }
}
