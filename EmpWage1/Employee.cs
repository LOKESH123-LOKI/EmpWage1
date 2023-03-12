using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage1
{
    public class Employee
    {
        const int IS_FULLTIME = 1, WagePerHour = 20, DailyHours = 8, PartTimeHours = 8, IS_HALFTIME = 2;
        public void attendance()
        {
            Random random = new Random();
            int variable = random.Next(0, 2);
            if (variable == IS_FULLTIME)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
        }
        public void Calculate()
        {
            int Salary = 0;
            Random random = new Random();
            int variable = random.Next(0, 2);
            if (variable == IS_FULLTIME)
                Salary = WagePerHour * DailyHours;
            Console.WriteLine("Salary is" + Salary);
        }
        public void PartTimeWage()
        {
            int salary = 0;
            Random random = new Random();
            int variable=random.Next(0, 2);
            if (variable == IS_FULLTIME)
            {
                salary=WagePerHour * DailyHours;
            }
            else
                if (variable == IS_HALFTIME)
            {
                salary=WagePerHour /2* DailyHours;
            }
            Console.WriteLine("salary is" + salary);
        }

    }
}
