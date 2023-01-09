using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class ComputeEmpWages
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public static void ComputeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDay = 0;
            while (totalEmpHrs < MAX_HRS_IN_MONTH && totalWorkingDay < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDay++;

                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day {0} daily employee hours {1} total employee hours {2}", totalWorkingDay, empHrs, totalEmpHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee wage is " + totalEmpWage);
        }
    }
}
