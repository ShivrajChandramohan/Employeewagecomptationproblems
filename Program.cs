using NonStaticEmpWageProblem;

namespace EmployeeWageComutationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation problem");
            EmpAttendence Attendance = new EmpAttendence();
            Attendance.EmployeeCheck();
        }
    }
}