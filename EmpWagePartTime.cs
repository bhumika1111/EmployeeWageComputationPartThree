using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    /// <summary>
    /// Here We Check Only Employee Is Present Or Absent By Using Random Function.
    /// Note:Here We Write Code Using Non-Static Method.
    /// </summary>
    public class EmpWagePartTime
    {
        /// <summary>
        /// Checks the employee part time.
        /// </summary>
        public void CheckEmployeePartTime()
        {
            //constant
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            //variables

            int empwage = 0;
            int empHrs = 0;

            Random random = new Random();

            int empCheck = random.Next(3);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Is Full Time");
                empHrs = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Employee Is Part Time");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
                empHrs = 0;
            }
            empwage = EMP_RATE_PER_HOUR * empHrs;
            Console.WriteLine("Employee Wage:" + empwage);

        }
    }
}
