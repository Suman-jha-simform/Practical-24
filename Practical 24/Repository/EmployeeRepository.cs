using Microsoft.EntityFrameworkCore;
using Practical_24.Interface;
using Practical_24.Model;

namespace Practical_24.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationContext _context;
        public EmployeeRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task DeleteEmployeeAsync(Employee employee)
        {
            var employeeEntity = await GetEmployeeByIdAsync(employee.Id);
            if (employeeEntity != null)
            {
                employeeEntity.Status = true;
                _context.Employees.Update(employeeEntity);
            }
        }

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await _context.Employees.Where(emp => emp.Status == false).ToListAsync();
        }

        public async Task<Employee?> GetEmployeeByIdAsync(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(emp => emp.Id == id && emp.Status == false);
        }

        public async Task CreateEmployeeAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }
    }
}
