using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management
{
    public class Employee
    {
        public static void UC1Attendence()
        {

            int IsPresent = 1;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == IsPresent)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

        }
    }
}
