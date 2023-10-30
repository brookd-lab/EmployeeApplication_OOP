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
    public class ReadView
    {
        private readonly Employees _employees;

        public ReadView(Employees employees)
        {
            _employees = employees;
        }

        public void RunReadView()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the Id of the employee you wish to read.");

            int id = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(DisplayText.DisplayAppName());

            Employee employee = _employees.Find(id);

            if (employee != null)
            {   
                Console.WriteLine(DisplayText.GetReadHeading());

                Console.WriteLine($"Name: {employee.Name}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please press any key to return to the main view...");
            }
            else
            {
                Console.WriteLine(DisplayText.GetEmployeeNotFoundMessage(id));
            }
            Console.ReadKey();
        }
    }
}
