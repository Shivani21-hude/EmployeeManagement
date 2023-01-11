using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management
{
    public class CompanyEmpWage
    {

        public string company;
        public int Emp_Rate_per_hour;
        public int num_of_working_days;
        public int max_hrs_in_month;
        public int totalempwage;
        public CompanyEmpWage(string company, int emp_Rate_per_hour, int num_of_working_days, int max_hrs_in_month)
        {
            this.company = company;
            this.Emp_Rate_per_hour = emp_Rate_per_hour;
            this.num_of_working_days = num_of_working_days;
            this.max_hrs_in_month = max_hrs_in_month;
        }
        public void setTotalEmpWage(int totalempwage)
        {
            this.totalempwage = totalempwage;
        }
        public string toString()
        {
            return "Total wage for company " + this.company + " is " + this.totalempwage;
        }
    }
    //Calculating emp wage for multiple companies using array:

    public class EmpWageBuilderArray
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;

        private int numofCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;


        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company,int Emp_Rate_per_hour,int num_of_working_days,int max_hrs_in_month)
        {
            companyEmpWageArray[this.numofCompany]=new CompanyEmpWage(company,Emp_Rate_per_hour,num_of_working_days,max_hrs_in_month);
            numofCompany++;
        }

        public void ComputeEmpWage()
        {
            for (int i = 0; i < numofCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int emp_hrs = 0;

            int totalworkingdays = 0, totalempHrs = 0;
            while (totalempHrs <= companyEmpWage.max_hrs_in_month && totalworkingdays < companyEmpWage.num_of_working_days)
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
            return totalempHrs * companyEmpWage.Emp_Rate_per_hour;
        }

    }
}
