using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    internal class EmployeeWage
    {

        public const int is_Fulltime = 1;
        public const int is_Parttime = 2;
        private string company;
        private int mAX_HRS_PER_MONTH;
        private int no_OF_Working_Days;
        private int empRatePerHr;
        private int totalEmpWage;
        public EmployeeWage(string company, int mAX_HRS_PER_MONTH, int no_OF_Working_Days, int empRatePerHr)
        {
            this.company = company;
            this.mAX_HRS_PER_MONTH = mAX_HRS_PER_MONTH;
            this.no_OF_Working_Days = no_OF_Working_Days;
            this.empRatePerHr = empRatePerHr;
        }
        public void ComputeWage()
        {
            Console.WriteLine("Welcome to Employee Wage Computation problem");
            int empHrs;
            int totalEmpHrs = 0;
            int day = 1;
            while (day <= no_OF_Working_Days && totalEmpHrs <= mAX_HRS_PER_MONTH)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                switch (empCheck)
                {
                    case is_Fulltime:
                        Console.WriteLine("Employee is present full time");
                        empHrs = 8;
                        break;
                    case is_Parttime:
                        Console.WriteLine("Employee is present part time");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is absent");
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine(" Day   #: " + day + "  Employee hours attended till the day  is " + totalEmpHrs);
                day++;
            }
            totalEmpWage = totalEmpHrs * empRatePerHr;
        }
        public string toString()
        {
            return "Total Employee Wage for the Company " + this.company + " is " + this.totalEmpWage;
        }
        public static void Main(string[] args)
        {
            EmployeeWage Reliance = new EmployeeWage("Reliance", 100, 30, 240);
            Reliance.ComputeWage();
            Console.WriteLine(Reliance.toString());
            EmployeeWage tata = new EmployeeWage("tata", 120, 26, 208);
            tata.ComputeWage();
            Console.WriteLine(tata.toString());
            EmployeeWage Microsoft = new EmployeeWage("AdityaBirla", 150, 26, 180);
            Microsoft.ComputeWage();
            Console.WriteLine(Microsoft.toString());

        }
    }
}