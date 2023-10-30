﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class Employee
    {
        [Key]
        public int Id { get; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public string GetData()
        {
            return $"Name: {Name}, Salary: {Salary}";
        }
    }
}
