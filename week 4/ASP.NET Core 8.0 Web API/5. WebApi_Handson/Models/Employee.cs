namespace ApiJsonWebToken.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
