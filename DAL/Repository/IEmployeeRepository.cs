using DAL.Data;

namespace DAL.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        void CreateEmployee(Employee employee);
        void UpdateEmployeeById(int id, Employee employee);
        void DeleteEmployeeById(int id);
    }
}
