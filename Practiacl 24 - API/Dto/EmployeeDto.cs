using Practical_24.Model;

namespace Practical_24.Dto
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public string? Email { get; set; }
        public DateTime JoinDate { get; set; }
        public Department DepartmentId { get; set; }
        public bool Status { get; set; } = false;
    }
}
