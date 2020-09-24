using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_8_fix_
{
    public class Engineer : Employee, ICalc
    {
        public int allowance;

        public int CalcSalary()
        {
           
            int actualSalary = (pSalary * pDays) / 24 + allowance;
            return actualSalary;
        }

        public override void display()
        {
            Console.WriteLine(this);
            Console.WriteLine("phu cap: "+allowance);
            Console.WriteLine("===Luong cuoi thang: " + CalcSalary());

        }
        public override string ToString()
        {
            return base.ToString() +string.Format($", {allowance}, {CalcSalary()}");
        }

        public override void input()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter id: ");
                    pID = Console.ReadLine().Trim();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Enter name: ");
                    pName = Console.ReadLine().Trim();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Enter salary: ");
                    pSalary = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Enter days: ");
                    pDays = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Nhap tro cap: ");
                    allowance = int.Parse(Console.ReadLine().Trim());
                    if (allowance >= 0)
                    {
                        break;
                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine("LOi: "+e.Message);
                }
            }
        }
    }
}
