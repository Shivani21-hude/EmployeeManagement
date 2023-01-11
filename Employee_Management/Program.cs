using Employee_Management;
using System;
namespace EmployeeManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Management \n");

            Employee dmart = new Employee("Dmart", 20, 20, 100);
            Employee reliance = new Employee("Reliance", 25, 15, 80);
            dmart.ComputeEmpWage();
             reliance.ComputeEmpWage();

            Console.WriteLine(dmart.toString());
            Console.WriteLine(reliance.toString());
        }
    }
}