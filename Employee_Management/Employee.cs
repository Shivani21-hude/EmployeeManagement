using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management
{
    public class Employee
    {

        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int Emp_Rate_per_hour = 20;
        public const int num_of_working_days = 20;
        public const int max_hrs_in_month = 100;
        public static void Uc6TotalWage()
        {
            int emp_hrs = 0;
            int EmpWage = 0;
            int totalempwage = 0, totalworkingdays = 0, totalempHrs = 0;
            while (totalempHrs <= max_hrs_in_month && totalworkingdays < num_of_working_days)
            {
                totalworkingdays++;

                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case isFullTime:
                        emp_hrs = 8;
                        break;

                    case isPartTime:
                        emp_hrs = 4;
                        break;

                    default:
                        emp_hrs = 0;
                        break;

                }
                totalempHrs += emp_hrs;
                Console.WriteLine("Day:" + totalworkingdays + "Employee hrs : " + emp_hrs);
            }
            totalempwage = totalempHrs * Emp_Rate_per_hour;
            Console.WriteLine("Total employee wage is: " + totalempwage);

        }

    }
}
