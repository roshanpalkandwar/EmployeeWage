using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    public interface IComputeEmpWage
    {
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDay, int maxHourPerMonth);
        public void ComputeEmpWage();


    }

    public class CompanyEmployeeWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkinDay;
        public int maxHourPerMonth;
        public int totalEmpWage;

        public CompanyEmployeeWage(string company, int empRatePerHour, int numOfWorkingDay, int maxHourPerMonth)
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

    public class EmpWageBuilder11 : IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmployeeWage[] companyEmpWageArray;

        public EmpWageBuilder11()
        {
            this.companyEmpWageArray = new CompanyEmployeeWage[5];
        }
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDay, int maxHourPerMonth)
        {

            companyEmpWageArray[this.numOfCompany] = new CompanyEmployeeWage(company, empRatePerHour, numOfWorkingDay, maxHourPerMonth);
            numOfCompany++;
        }

        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].SetTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].ToString());
            }
        }

        private int ComputeEmpWage(CompanyEmployeeWage companyEmpWage)
        {
            //variable
            int empHrs = 0, totalEmpHrs = 0, totalWorkinDays = 0;
            //computation
            while (totalEmpHrs <= companyEmpWage.maxHourPerMonth && totalWorkinDays < companyEmpWage.numOfWorkinDay)
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
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }

    }
}
