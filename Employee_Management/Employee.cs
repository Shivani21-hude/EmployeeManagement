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
        public static void Uc5MonthlyWage()
        {
            int emp_hrs = 0;
            int EmpWage = 0;
            int totalempwage = 0;
            for (int day = 1; day <= num_of_working_days; day++)
            {

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
                EmpWage = emp_hrs * Emp_Rate_per_hour;
                totalempwage += EmpWage;
                Console.WriteLine("Day :" + day + "  employee wage :" + EmpWage);
            }

            Console.WriteLine("Total emp wage : " + totalempwage);
        }

    }
}
