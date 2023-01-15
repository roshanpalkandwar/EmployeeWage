using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public interface IComputEmployeeWage
    {
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDay, int maxHourPerMonth);
        public void ComputeEmpWage();

        public int GetTotalWage(string company);
    }

    public class CompanysEmployeeWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkinDay;
        public int maxHourPerMonth;
        public int totalEmpWage;

        public CompanysEmployeeWage(string company, int empRatePerHour, int numOfWorkingDay, int maxHourPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkinDay = numOfWorkingDay;
            this.maxHourPerMonth = maxHourPerMonth;
        }


        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string ToString()
        {
            return "Total Employee wage for company : " + this.company + " is : " + this.totalEmpWage;
        }
    }


    public class EmployeeWageBuilder : IComputEmployeeWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private LinkedList<CompanysEmployeeWage> companysEmployeeWageList;
        private Dictionary<string, CompanysEmployeeWage> companyToEmpWageMap;

        public EmployeeWageBuilder()
        {
            this.companysEmployeeWageList = new LinkedList<CompanysEmployeeWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanysEmployeeWage>();
        }

        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDay, int maxHourPerMonth)
        {
            CompanysEmployeeWage companysEmployeeWage = new CompanysEmployeeWage(company, empRatePerHour, numOfWorkingDay, maxHourPerMonth);
            this.companysEmployeeWageList.AddLast(companysEmployeeWage);
            this.companyToEmpWageMap.Add(company, companysEmployeeWage);
        }
        public void ComputeEmpWage()
        {
            foreach (CompanysEmployeeWage companysEmployeeWage in this.companysEmployeeWageList)
            {
                companysEmployeeWage.SetTotalEmpWage(this.ComputeEmpWage(companysEmployeeWage));
                Console.WriteLine(companysEmployeeWage.ToString());
            }
        }

        private int ComputeEmpWage(CompanysEmployeeWage companysEmployeeWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkinDays = 0;
            //computation
            while (totalEmpHrs <= companysEmployeeWage.maxHourPerMonth && totalWorkinDays < companysEmployeeWage.numOfWorkinDay)
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
                Console.WriteLine("Day#: " + totalWorkinDays + " Employee hours : " + empHrs);
            }
            return totalEmpHrs * companysEmployeeWage.empRatePerHour;
        }

        public int GetTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }
    }
}
