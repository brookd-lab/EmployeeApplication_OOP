using EmployeeComponent.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponent
{
    public static class DisplayText
    {
        public static string DisplayAppName()
        {
            return "Employees";
        }

        public static string DisplayMenuOptions()
        {
            return "[a] Add, [r] Read, [u] Update, [d] Delete, any other key quits";
        }

        public static string GetCreateHeading()
        {
            string heading = "Add Employee\n";
            return heading;
        }

        public static string GetReadHeading()
        {
            string heading = "Get Employee\n";
            return heading;
        }

        public static string GetUpdateHeading(Employee employee)
        {
            string heading = $"Update Employee Details for {employee.Name} Id: {employee.Id}\n";

            return $"{heading}";
        }

        public static string GetDeleteHeading(Employee employee)
        {
            string heading = $"Delete Employee Details for {employee.Name} Id: {employee.Id}\n";

            return $"{heading}";
        }
        public static string GetUpdateViewAdditionalInstructions()
        {
            return "Note: a blank field will leave relevant field unmodified.\n";
        }

        public static string GetEmployeeNotFoundMessage(int id)
        {
            return $"Could not find employee with Id({id}). Please press any key to return to the main view...";

        }
    }
}
