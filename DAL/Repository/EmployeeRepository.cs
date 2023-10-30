using DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

       IEnumerable<Employee> IEmployeeRepository.GetAllEmployees()
        {
            var employeeList = _context.Employee.ToList();
            return employeeList;
        }
        Employee IEmployeeRepository.GetEmployeeById(int id)
        {
            Employee? employee = _context.Employee.Find(id);
            return employee;
        }

        void IEmployeeRepository.CreateEmployee(Employee employee)
        {
            _context.Employee.Add(employee);
            _context.SaveChanges();
        }

        void IEmployeeRepository.UpdateEmployeeById(int id, Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();
        }

        void IEmployeeRepository.DeleteEmployeeById(int id)
        {
            var employeeToDelete = _context.Employee.Find(id);
            if (employeeToDelete != null)
            {
                _context.Remove(employeeToDelete);
                _context.SaveChanges();
            }
        }
    }
}
