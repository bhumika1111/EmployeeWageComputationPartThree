using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    /// <summary>
    /// Here We Check Only Employee Is Present Or Absent By Using Random Function.
    /// /// Note : Here We Write Code Using Non-Static Method . 
    /// </summary>
    public class EmployeeCheck
    {
        /// <summary>
        /// Checks the employee attendance.
        /// </summary>

        public void CheckEmployeeAttendance()

        {
                int IS_FUll_TIME = 1;

                Random random = new Random();
                int empCheck = random.Next(2);

                if (empCheck == IS_FUll_TIME)
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
