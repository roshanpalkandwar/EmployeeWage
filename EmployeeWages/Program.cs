using EmployeeWages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage");
            Console.WriteLine("Choose Option\n 1.Check Absent or Present\t 2.Calculate Daily Wage\t 3.Part Time Wage\t 4.Emp Wage for month\t 5.wages for month\t 6.employee wages for monthly \t 7.emp wages\n8.wages for compnay\n9.emwges for miltiple company \n10.EmpWageBuilder");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    EmployeeCheckAttendance.EmployeePresentAbsent();
                    break;
                case 2:
                    DailyWage.CalculateDailyWage();
                    break;
                case 3:
                    PartTimeWage.CalculatePartTimeWage();
                    break;
                case 4:
                    EmpWageSwitchCase.WageForMonth();
                    break;
                case 5:
                    wagesForMonth.calculateEmplymMonthWages();
                    break;
                case 6:
                    empWagesForMonthHours.calculateWages();
                    break;
                default:
                    Console.WriteLine("Entered Wrong Choice");
                    break;
                case 7:
                    ComputeEmpWages.ComputeEmpWage();
                    break;
                case 8:
                    UsingMultipaleCompany.ComputeWaageForMultipleCompany("TATA", 20, 20, 100);
                    UsingMultipaleCompany.ComputeWaageForMultipleCompany("BMW", 20, 20, 100);
                    UsingMultipaleCompany.ComputeWaageForMultipleCompany("TCS", 20, 20, 100);
                    Console.WriteLine();
                    break;
                case 9:

                    EmpWages TATA = new EmpWages("TATA", 20, 20, 100);
                    EmpWages BMW = new EmpWages("BMW", 20, 20, 100);
                    EmpWages TCS = new EmpWages("TCS", 20, 20, 100);

                    TATA.ComputeEmployeeWage();
                    Console.WriteLine(TATA.ToString());
                    BMW.ComputeEmployeeWage();
                    Console.WriteLine(BMW.ToString());
                    TCS.ComputeEmployeeWage();
                    Console.WriteLine(TCS.ToString());
                    break;
                case 10:
                    EmpWageBuilder empWageBuilderArray = new EmpWageBuilder();
                    empWageBuilderArray.addCompanyEmpWage("TATA", 20, 2, 10);
                    empWageBuilderArray.addCompanyEmpWage("BMW", 10, 4, 20);
                    empWageBuilderArray.addCompanyEmpWage("TCS", 10, 4, 20);
                    empWageBuilderArray.computeEmpWage();
                    break;
            }
            Console.ReadLine();
        }
    }
}