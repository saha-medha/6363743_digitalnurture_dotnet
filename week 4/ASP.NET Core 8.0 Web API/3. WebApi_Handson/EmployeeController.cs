using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CustomEmployeeAPI.Models;
using CustomEmployeeAPI.Filters; 
namespace CustomEmployeeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [CustomAuthFilter]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees = new List<Employee>();

        public EmployeeController()
        {
            if (_employees.Count == 0)
                _employees = GetStandardEmployeeList();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee {
                    Id = 1,
                    Name = "Medha Saha",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "IT" },
                    Skills = new List<Skill> {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "SQL" }
                    },
                    DateOfBirth = new DateTime(1999, 8, 12)
                }
            };
        }
        [HttpGet("GetStandard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [AllowAnonymous]
        public ActionResult<List<Employee>> GetStandard()
        {
            return Ok(_employees);
        }
        [HttpPost]
        public ActionResult<Employee> AddEmployee([FromBody] Employee emp)
        {
            _employees.Add(emp);
            return Ok(emp);
        }
    }
}
