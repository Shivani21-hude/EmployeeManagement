using Employee_Management;
using System;
namespace EmployeeManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Management \n");

            Employee.ComputeEmpWage("Dmart",20,20,100);
            Employee.ComputeEmpWage("Reliance", 25, 15, 80);

        }
    }
}