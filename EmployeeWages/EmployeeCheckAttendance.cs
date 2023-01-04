using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmployeeCheckAttendance
    {
        public static void EmployeePresentAbsent()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            Console.WriteLine("Random Generated value " + empCheck);
            if (empCheck == 0)
            {
                Console.WriteLine("Employee Present");
            }
            else
            {
                Console.WriteLine("Employee Absent");
            }
        }
    }
}
