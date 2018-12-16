﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageManager
{
    public abstract class Employee
    {
        public string Name { get; set; }

        public int YearsOfService { get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }

        public abstract int GetSalary();        
    }
}
