using Employee_Management;
using System;
namespace EmployeeManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Management \n");

            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
            empWageBuilderArray.addCompanyEmpWage("Dmart", 20, 20, 100);
            empWageBuilderArray.addCompanyEmpWage("Reliance", 25, 15, 80);
            empWageBuilderArray.addCompanyEmpWage("Textile", 25, 18, 70);
            empWageBuilderArray.addCompanyEmpWage("TCS", 25, 22, 110);

           empWageBuilderArray.ComputeEmpWage();
          

        }
    }
}