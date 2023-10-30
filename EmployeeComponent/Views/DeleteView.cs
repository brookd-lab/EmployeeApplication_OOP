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
    public class DeleteView
    {
        private readonly Employees _employees;

        public DeleteView(Employees employees)
        {
            _employees = employees;
        }

        public void RunDeleteView()
        {
            if (!_employees.HasData())
            {
                Console.WriteLine();
                Console.WriteLine("No Data to Delete");
                Thread.Sleep(1000);
                return;
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the Id of the employee you wish to delete.");

            int id = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine(DisplayText.DisplayAppName());

            Employee employee = _employees.Find(id);

            if (employee != null)
            {
                string name = null;
                string salary = null;

                Console.WriteLine(DisplayText.GetDeleteHeading(employee));

                Console.WriteLine($"Name: {employee.Name}");
                Console.WriteLine($"Salary: {employee.Salary}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Are you sure [Y] to delete or any other key to cancel.");

                ConsoleKey consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.Y)
                {
                    _employees.Delete(employee);
                }
            }
        }
    }
}
