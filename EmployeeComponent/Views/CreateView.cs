using EmployeeComponent.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponent.Views
{
    public class CreateView
    {
        private readonly Employees _employees;

        public CreateView(Employees employees)
        {
            _employees = employees;
        }

        public void RunCreateView()
        {
            string name = "";
            decimal salary = 0;

            Console.Clear();

            Console.WriteLine(DisplayText.DisplayAppName());

            Console.WriteLine();
            Console.WriteLine(DisplayText.GetCreateHeading());

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Salary: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Please press the [S] key to save the new employee record to the system or any other key to cancel.");

            ConsoleKey consoleKey = Console.ReadKey().Key;

            if (consoleKey == ConsoleKey.S)
            {
                _employees.Add(EmployeeFactory.CreateEmployee(name, salary));
            }

            



        }
    }
}
