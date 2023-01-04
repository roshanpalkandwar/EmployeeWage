using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class DailyWage
    {
        public static void CalculateDailyWage()
        {
            int empHrs = 0;
            const int EMP_RATE_PER_HOUR = 20;
            Random random = new Random();
            int empcheck = random.Next(0, 2);//0,1
            Console.WriteLine("Random generated value" + empcheck);
            if (empcheck == 0)
            {
                Console.WriteLine("Employee Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee Absent");
                empHrs = 0;

            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Daily emp wage is " + empWage);
        }
    }
}
