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
        private string company;
        private int Emp_Rate_per_hour;
        private int  num_of_working_days;
        private int max_hrs_in_month;
        private int totalempwage;
        public Employee(string company, int emp_Rate_per_hour, int num_of_working_days, int max_hrs_in_month)
        {
            this.company = company;
            this.Emp_Rate_per_hour = emp_Rate_per_hour;
            this.num_of_working_days = num_of_working_days;
            this.max_hrs_in_month = max_hrs_in_month;
        }

        public void ComputeEmpWage()
        {
            int emp_hrs = 0;
            
            int totalworkingdays = 0, totalempHrs = 0;
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
            Console.WriteLine("Total employee wage for " +company + " is : " + totalempwage);
           
        }
        public string toString()
        {
            return "Total wage for company " + this.company + " is " + this.totalempwage;
        }

    }
}
