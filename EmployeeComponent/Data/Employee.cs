using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponent.Data
{
    public class Employee
    {
        public static int newId;
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee()
        {
            newId++;
            Id = newId;
        }

        public Employee(string name, decimal salary):this()
        {   
            Name = name;
            Salary = salary;
        }

        public string GetData()
        {
            return $"{Id}] Name: {Name}, Salary: {Salary}";
        }
    }


}
