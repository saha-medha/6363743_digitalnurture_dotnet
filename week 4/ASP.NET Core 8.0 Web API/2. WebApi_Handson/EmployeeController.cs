using Microsoft.AspNetCore.Mvc;

namespace SwaggerPostmanDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Medha" },
            new Employee { Id = 2, Name = "Saha" }
        };
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(employees);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();
            return Ok(emp);
        }
        [HttpPost]
        public IActionResult Create([FromBody] Employee emp)
        {
            employees.Add(emp);
            return Ok(emp);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Employee emp)
        {
            var existing = employees.FirstOrDefault(e => e.Id == id);
            if (existing == null) return NotFound();
            existing.Name = emp.Name;
            return Ok(existing);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();
            employees.Remove(emp);
            return NoContent();
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
