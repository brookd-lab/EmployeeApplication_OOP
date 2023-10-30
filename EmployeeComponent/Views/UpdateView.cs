using EmployeeComponent.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponent.Views
{
    public class UpdateView
    {
        private readonly Employees _employees;

        public UpdateView(Employees employees)
        {
            _employees = employees;
        }

        public void RunUpdateView()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the Id of the employee you wish to edit.");

            int id = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(DisplayText.DisplayAppName());

            Employee employee = _employees.Find(id);

            if (employee != null)
            {
                string name = null;
                string salary = null;
                
                Console.WriteLine(DisplayText.GetUpdateHeading(employee));

                Console.WriteLine(DisplayText.GetUpdateViewAdditionalInstructions());

                Console.Write($"Name ({employee.Name}): ");
                name = Console.ReadLine();

                Console.Write($"Salary ({employee.Salary}): ");
                salary = Console.ReadLine();

                _employees.Update(employee,
                    (String.IsNullOrWhiteSpace(name) ? employee.Name : name),
                    (String.IsNullOrWhiteSpace(salary) ? employee.Salary : Convert.ToDecimal(salary))
                );

            }
            else
            {
                Console.WriteLine(DisplayText.GetEmployeeNotFoundMessage(id));
                Console.ReadKey();
            }
        }
    }
}
