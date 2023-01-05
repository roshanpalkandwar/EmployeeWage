using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class empWagesForMonthHours
    {
        public static void calculateWages()
        {
            const int EMP_RATE_PER_HOUR = 20;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int MAX_HRS_IN_MONTH = 100;
            const int NUM_WORKING_DAY = 20;

            int emhrs = 0, totalemhrs = 0, totalWorkingDay = 0;
            while (totalemhrs <= MAX_HRS_IN_MONTH && totalWorkingDay < NUM_WORKING_DAY)
            {
                totalWorkingDay++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        emhrs = 8;
                        break;
                    case IS_PART_TIME:
                        emhrs = 4;
                        break;
                    default:
                        emhrs = 0;
                        break;
                }
                totalemhrs = emhrs + totalemhrs;
                Console.WriteLine("day {0} and emhrs{1}", +totalWorkingDay, +totalemhrs);


            }
            int totalempwages = totalemhrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("total emp wages is  {0}", +totalempwages);
        }

    }
}
