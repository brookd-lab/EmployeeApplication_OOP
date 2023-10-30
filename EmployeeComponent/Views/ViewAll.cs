using EmployeeComponent.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponent.Views
{
    public class ViewAll
    {
        public readonly Employees _employees;

        public ViewAll(Employees employees)
        {
            _employees = employees;
        }

        public void RunViewAll()
        {
            Console.WriteLine(DisplayText.DisplayAppName());

            foreach(Employee employee in _employees)
            {
                Console.WriteLine(employee.GetData());
            }
        }

    }
}
