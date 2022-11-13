using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    internal class EmployeeWage
    {
        static void Main(string[] args)
        {
            //main
            Console.WriteLine("Welcome to EmployeeWage Computation");
            //UC1 
            Console.WriteLine("Welcome to EmployeeWage Computation");
            //UC1 
            const int EMP_RATE_PER_HR = 20;
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int empWage = 0;
            int empHrs = 0;

            Random r = new Random();
            int employeeInput = r.Next(0, 3);
            switch (employeeInput)
            {
                case FULL_TIME:
                    Console.WriteLine("FullTime Employee is Present");
                    empHrs = 8;
                    break;
                case PART_TIME:
                    Console.WriteLine("PartTime Employee is Present");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    break;
            }
            //UC2
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Daily Employee Wage is:" + empWage);
            Console.ReadLine();

        }
    }
}
