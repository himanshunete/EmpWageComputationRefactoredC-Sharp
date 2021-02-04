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
            Random rand = new Random();
            int empCheck = rand.Next(0, 2);
            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
}
