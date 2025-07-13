using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
namespace StudentWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Medha" },
            new Student { Id = 2, Name = "Saha" }
        };
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(students);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();
            return Ok(student);
        }
        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            students.Add(student);
            return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student updatedStudent)
        {
            var existingStudent = students.FirstOrDefault(s => s.Id == id);
            if (existingStudent == null) return NotFound();

            existingStudent.Name = updatedStudent.Name;
            return Ok(existingStudent);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null) return NotFound();
            students.Remove(student);
            return NoContent();
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
