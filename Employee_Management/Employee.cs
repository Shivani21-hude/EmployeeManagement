using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management
{
    public class Employee
    {
        public static void UC3PartTime()
        {


            int Fulltime = 1;
            int PartTime = 2;
            int emp_hrs = 0;
            int Emp_rate_per_hour = 20;
            int empwage = 0;

            Random random = new Random();
            int empcheck = random.Next(0, 3);

            if (empcheck == Fulltime)
            {
                emp_hrs = 8;

            }
            if else(empcheck==PartTime)
            {
                emp_hrs = 4;
            }
            else
            {
                emp_hrs = 0;

            }
            empwage = emp_hrs * Emp_rate_per_hour;
            Console.WriteLine("Daily employee wage :" + empwage);
        }
    }
}
