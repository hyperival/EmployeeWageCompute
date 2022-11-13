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
            int employeePresent = 1;
            Random r = new Random();
            int employeeInput = r.Next(0, 2);

            if (employeePresent == employeeInput)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");

            Console.ReadLine();

        }
    }
}
