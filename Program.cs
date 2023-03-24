using NonStaticEmpWageProblem;

namespace EmployeeWageComutationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation problem");
            EmpPartTimeWage Wage = new EmpPartTimeWage();
            Wage.PartTimeEmployee();
        }
    }
}