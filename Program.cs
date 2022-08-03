using System;

namespace EmpWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Welcome To Employee Wage Computation Program****************");
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            Console.WriteLine("*****Output For Employee Is Present Or Absent.******");
             EmployeeCheck case1 = new EmployeeCheck();
             case1.CheckEmployeeAttendance();

             Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::");
             Console.WriteLine("******Output For Calculate Employee Daily Wage******");
             EmpWageDaily case2 = new EmpWageDaily();
             case2.CheckEmpAttendanceFullTime();

             Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::");
             Console.WriteLine("*****Output For Calculating When We Add Part Time****** ");
             EmpWagePartTime case3 = new EmpWagePartTime();
             case3.CheckEmployeePartTime();

             Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::");
             Console.WriteLine("*****Output For Calculating Employee Wage Using Switch Case.******** ");
             SwitchCase case4 = new SwitchCase();
             case4.CheckEmpAttendance();

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("*****Output For Employee Wage For A Month*********");
            EmpWageMonth case5 = new EmpWageMonth();
            case5.CheckEmpWageForMonth();

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("*****Output For  Total Employee Wage And Hrs In Month*********");
            EmpWageHrsInMonth case6 = new EmpWageHrsInMonth();
            case6.CheckTotalEmpWage();

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("*****Output For Total Employee Wage And Return That Wage To Method*********");
            ComputeEmpWage case7 = new ComputeEmpWage();
              int result =  case7.CheckEmployeeWage();


        }
    }
}
