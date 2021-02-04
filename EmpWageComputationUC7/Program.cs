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
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 0;
            int EMP_RATE_PER_HOUR = 20;
            int NUM_OF_WORKING_DAYS = 20;
            int MAX_NUM_OF_HOURS = 100;

            //Variable
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            Random rand = new Random();
            int empCheck = rand.Next(0, 2);
            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine(" Employee is Present ");
                while (totalEmpHrs <= MAX_NUM_OF_HOURS && totalWorkingDays <= NUM_OF_WORKING_DAYS)
                {
                    totalEmpHrs++;
                    totalWorkingDays++;
                    //Variables  
                    int empHrs;
                    int empWage;
                    int workingTime = rand.Next(0, 2);
                    switch (workingTime)
                    {
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    empWage = empHrs * EMP_RATE_PER_HOUR;
                    totalEmpWage += empWage;
                    Console.WriteLine(" Emp Daily Wage: " + empWage);
                }
                Console.WriteLine("Emp Total Wage: " + totalEmpWage);
            }


        }
    }
}
