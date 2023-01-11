using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class EmpWages
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkinDay;
        private int maxHourPerMonth;
        private int totalEmpWage;

        public EmpWages(string company, int empRatePerHour, int numOfWorkinDay, int maxHourPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkinDay = numOfWorkinDay;
            this.maxHourPerMonth = maxHourPerMonth;

        }

        public void ComputeEmployeeWage()
        {

            int empHrs = 0, totalEmpHrs = 0, totalWorkinDays = 0;

            while (totalEmpHrs <= this.maxHourPerMonth && totalWorkinDays < this.numOfWorkinDay)
            {
                totalWorkinDays++;

                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;
                        break;
                    case 2:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#: " + totalWorkinDays + " Employee hours : " + empHrs + " Total employee hours : " + totalEmpHrs);
            }
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total employee wage for company : " + company + " is : " + totalEmpWage);
        }

        public string toString()
        {
            return "Total employee wage for company : " + this.company + " is : " + this.totalEmpWage;
        }
    }
}
