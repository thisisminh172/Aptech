using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_8
{
    public class Engineer : Employee, ICalc
    {
        public int? allowance;
        
        public int CalcSalary()
        {
            if (allowance == null)
            {
                allowance = 0;
            }
            int actualSalary = (pSalary * pDays)/24 + (int)allowance;
            return actualSalary;
        }

        public override void display()
        {
            Console.WriteLine(this);
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
                }catch(Exception e)
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
        }


    }
    
}
