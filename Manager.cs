using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageManager
{
    public class Manager : Employee
    {       
        public override int GetSalary()
        {
            return 3000;
        }
    }
}
