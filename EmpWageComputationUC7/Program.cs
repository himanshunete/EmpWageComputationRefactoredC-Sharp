using System;

namespace EmpWageComputationUC7
{
    class EmpWageBuilder
    {
        //Constant
        public const int IS_PRESENT = 1;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 0;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_NUM_OF_HOURS = 100;

        //Class Variable
        public static int totalEmpWage = 0;
        public static int totalEmpHrs = 0;
        public static int totalWorkingDays = 0;
        public static int empHrs;
        public static int empWage;

        // Class Method
        public static void CheckingWage()
        {
            Console.WriteLine("Welcome To Employee Wage Computation Program");

            Random rand = new Random();
            int empCheck = rand.Next(0, 2);
            if (empCheck == IS_PRESENT)
            {
                Console.WriteLine(" Employee is Present ");
                while (totalEmpHrs <= MAX_NUM_OF_HOURS && totalWorkingDays <= NUM_OF_WORKING_DAYS)
                {
                    totalEmpHrs++;
                    totalWorkingDays++;
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

            else
            {
                Console.WriteLine(" Employee is Absent ");
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder.CheckingWage();
        }
    }
}
