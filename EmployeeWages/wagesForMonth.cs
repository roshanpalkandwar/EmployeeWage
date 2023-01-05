using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class wagesForMonth
    {
        public static void calculateEmplymMonthWages()
        {
            int emphrs = 0;
            int empWages = 0;
            int totalEmpWages = 0;
            const int EMP_RATE_PER_HOUR = 20;

            for (int day = 1; day < 21; day++)

            {
                Console.WriteLine("employee day is " + day);
                Random random = new Random();
                int empcheck = random.Next(1, 3);

                switch (empcheck)
                {
                    case 1:
                        emphrs = 8;
                        break;
                    case 2:
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }

                empWages = emphrs * EMP_RATE_PER_HOUR;
                totalEmpWages += empWages;
                Console.WriteLine("daily emp wage is {0} total emp wage {1}", empWages, totalEmpWages);
                Console.WriteLine("total emp wage is: " + totalEmpWages);

            }
        }
    }
}
