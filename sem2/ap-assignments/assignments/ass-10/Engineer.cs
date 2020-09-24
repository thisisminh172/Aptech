using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_10
{
    public class Engineer : Employee
    {
        public int Allowance;

        public override int CalcSalary()
        {
            return (pDays*pSalary)/24;
        }

        public override void Display()
        {
            Console.WriteLine(this+$", actual salary: {CalcSalary()}");
        }

    }
}
