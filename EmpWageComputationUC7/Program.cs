using System;

namespace EmpWageComputationUC7
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program");
            //Constant
            int IS_PRESENT = 1;
            int EMP_RATE_PER_HOUR = 20;

            //Variables  
            int empHrs;
            int empWage;
            Random rand = new Random();
            int empCheck = rand.Next(0, 2);
            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Daily Wage: " + empWage);

        }
    }
}
