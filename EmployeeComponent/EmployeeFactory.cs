using EmployeeComponent.Data;
using EmployeeComponent.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponent
{
    public class EmployeeFactory
    {
        private static CreateView _createView = null;
        private static ReadView _readView = null;
        private static UpdateView _updateView = null;
        private static DeleteView _deleteView = null;
        private static ViewAll _viewAll = null;

        public static Employee CreateEmployee(string name, decimal salary)
        {
            Employee employee = new Employee();
            employee.Name = name;
            employee.Salary = salary;
            return employee;
            //return new Employee(name, salary);
        }

        public static CreateView EmployeeCreateViewObject(Employees employees)
        {
            if (_createView == null)
            {
                _createView = new CreateView(employees);
            }

            return _createView;
        }

        public static ReadView EmployeeReadViewObject(Employees employees)
        {
            if (_readView == null)
            {
                _readView = new ReadView(employees);
            }

            return _readView;
        }

        public static UpdateView EmployeeUpdateViewObject(Employees employees)
        {
            if (_updateView == null)
            {
                _updateView = new UpdateView(employees);
            }

            return _updateView;
        }

        public static DeleteView EmployeeDeleteViewObject(Employees employees)
        {
            if (_deleteView == null)
            {
                _deleteView = new DeleteView(employees);
            }

            return _deleteView;
        }



        public static ViewAll EmployeeViewAll(Employees employees)
        {
            if (_viewAll == null)
            {
                _viewAll = new ViewAll(employees);
            }

            return _viewAll;
        }
    }
}
