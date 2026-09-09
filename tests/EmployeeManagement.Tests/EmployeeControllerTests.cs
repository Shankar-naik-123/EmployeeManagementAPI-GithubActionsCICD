using EmployeeManagement.API;
using EmployeeManagement.API.Controllers;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Tests
{
    public class EmployeeControllerTests
    {
        [Fact]
        public void GetEmployeesreturnsEmployees()
        {
            EmployeeController controller = new EmployeeController();
            var employees = controller.GetEmployees();
            Assert.NotNull(employees);
        }
        [Fact]
        public void AddEmployeesAddsEmployee()
        {
            EmployeeController controller = new EmployeeController();
            EmployeeDto e = new EmployeeDto
            {
                Name = "Test Name",
                Designation = "Test Designer",
                Adresss = "Test Adress",
                ServiceYears = 2
            };
            var result = controller.AddEmployee(e);
            Assert.IsType<Microsoft.AspNetCore.Mvc.OkObjectResult>(result);
            Assert.Contains(controller.GetEmployees(), e => e.Name == "Test Name");
        }
        
        [Fact]
        public void HealthCheck_ReturnsOkWithHealthyMessage()
        {
            var controller = new EmployeeController();
            var result = controller.HealthCheck();
            
            Assert.Equal("Sever is healthy!",  ((OkObjectResult)result).Value);
           ;
        }
    }
}

