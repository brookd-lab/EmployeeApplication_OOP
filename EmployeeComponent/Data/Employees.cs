using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponent.Data
{
    public class Employees
    {
        private readonly ArrayList _employees;
        
        public Employees()
        {
            _employees = new ArrayList();
        }

        public Employee this[int index]
        {
            get
            {
                return (Employee)_employees[index];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _employees.GetEnumerator();
        }

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void ResetIds()
        {
            int i = 1;
            foreach(Employee emp in _employees)
            {
                emp.Id = i++;
            }
        }

        public void Delete(Employee employee)
        {   
            _employees.Remove(employee);
            Employee.newId--;
            ResetIds();
        }

        public void Update(Employee employee, string name, decimal salary)
        {
            employee.Name = name;
            employee.Salary = salary;
        }

        public Employee Find(int id)
        {
            foreach (Employee emp in _employees)
            {
                if (emp.Id == id) return emp;
            }
            return null;
        }

        public void View()
        {
            foreach (Employee emp in _employees)
            {
                Console.WriteLine("Name: {0}, Salary: {1}", emp.Name, emp.Salary);
            }
        }

        public bool HasData()
        {   
            return _employees.Count > 0;
        }
    }
}
