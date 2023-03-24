using NonStaticEmpWageProblem;

namespace EmployeeWageComutationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation problem");
            EmpWageCase WageCase = new EmpWageCase();
            WageCase.EmployeeWageSwitchCase();
        }
    }
}