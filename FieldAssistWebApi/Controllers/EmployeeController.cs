using FieldAssistWebApi.Models;
using FieldAssistWebApi.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FieldAssistWebApi.Controllers
{
    [Route("Employee")]
    public class EmployeeController:ControllerBase
    {
        
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }



        //Create 
        [HttpPost("Create")]
        public IActionResult CreateEmployee([FromBody] Employee employee)
        {
            _employeeService.CreateEmployee(employee);
            return new JsonResult("employee created Successfully");
        }


        //Read
        [HttpGet("GetEmployees")]
        public IActionResult GetEmployees()
        {
            return new JsonResult(_employeeService.GetEmployees());
        }

        // Read employee By Id
        [HttpGet("GetEmployee/{id}")]
        public IActionResult GetEmployeeById([FromRoute] int id)
        {
            return new JsonResult(_employeeService.GetEmployeeById(id));
        }


        //update
        [HttpPost("Update")]
        public IActionResult UpdateEmployee([FromBody] Employee employee)
        {
            _employeeService.UpdateEmployee(employee);
            return new JsonResult("Updated Employee Success...");
        }

        //delete
        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteEmployee([FromRoute]int id)
        {
            return new JsonResult(_employeeService.DeleteEmployee(id));
        }



    }
}
