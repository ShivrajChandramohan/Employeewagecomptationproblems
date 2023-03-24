using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonStaticEmpWageProblem
{
    public class EmpWageTillCondition
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int Num_of_WorkingDays = 20;
        public const int MAX_HRS_IN_MONTH = 100;

        public void EmployeeWageCondition()
        {
            int empHrs = 0;
            int totalEmpWage = 0;
            int totalWorkingDays = 0;
            int empWage = 0;
            int totalEmpHrs = 0;


            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < Num_of_WorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int emp_Check = random.Next(3);

                switch (emp_Check)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        Console.WriteLine("The Employee is Present");
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        Console.WriteLine("The Employee is Present for Part Time");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total emp wage is: " + totalEmpWage);

        }
    }
}

