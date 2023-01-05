using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management
{
    public class Employee
    {
        public static void UC2EmployeeWage()
        {


            int Fulltime = 1;
            int emp_hrs = 0;
            int empWage = 20;

            Random random = new Random();
            int empcheck = random.Next(1, 3);

            if (empcheck == Fulltime)
            {
                emp_hrs = 8;

            }
            else
            {
                emp_hrs = 0;

            }
            emp_hrs = emp_hrs * empWage;
            Console.WriteLine("Daily employee wage :" + emp_hrs);
        }
    }
}
