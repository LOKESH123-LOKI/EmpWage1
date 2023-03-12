using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage1
{
    public class Employee
    {
        const int IS_PRESENT = 1;
        public void attendance()
        {
             Random random=new Random();
            int variable = random.Next(0, 2);
            if (variable == IS_PRESENT)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");

        }
    }
}
