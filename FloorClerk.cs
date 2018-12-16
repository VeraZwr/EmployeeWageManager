using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageManager
{
    public class FloorClerk : Employee
    {
        public FloorClerk(string name, int yearsOfService)
        {
            Name = name;
            YearsOfService = yearsOfService;
        }
        public override int GetSalary()
        {           
            return 1200;
        }
    }
}
