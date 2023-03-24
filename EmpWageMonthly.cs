using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonStaticEmpWageProblem
{
    public class EmpWageMonthly
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int Num_of_WorkingDays = 20;
        public void WagesforMonth()

        {

            int Emp_Hrs = 0;
            int Emp_Wage = 0;
            int totalEmpWage = 0;

            for (int day = 1; day < Num_of_WorkingDays; day++)
            {
                Random random = new Random();

                int emp_Check = random.Next(3);

                switch (emp_Check)
                {
                    case IS_FULL_TIME:
                        Emp_Hrs = 8;
                        Console.WriteLine("The Employee is Present");
                        break;
                    case IS_PART_TIME:
                        Emp_Hrs = 4;
                        Console.WriteLine("The Employee is Present for Part Time");
                        break;
                    default:
                        Emp_Hrs = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                Emp_Wage = Emp_Hrs * EMP_RATE_PER_HOUR;
                totalEmpWage += Emp_Wage;
                Console.WriteLine("{0} day and his Emp Wage is : {1}Rs", day, Emp_Wage);
            }
            Console.WriteLine("Total emp wage for month is: " + totalEmpWage);
        }
    }
}
