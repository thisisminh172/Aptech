using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ass_10
{
    public abstract class Employee
    {
        string id;
        int BaseSalary, WorkedDays;
        public string fullname;

        public string pID
        {
            get { return id; }
            set
            {

                if (Regex.IsMatch(value, "^E\\d{4}$"))
                {
                    id = value;
                }
                else
                {
                    throw new Exception("Exxxx");
                }

            }
        }
        public int pSalary
        {
            get { return BaseSalary; }
            set
            {

                if (value >= 100 & value <= 5000)
                {
                    BaseSalary = value;
                }
                else
                {
                    throw new Exception("[100-5000]");
                }

            }
        }
        public int pDays
        {
            get { return WorkedDays; }
            set
            {

                if (value >= 0 & value <= 31)
                {
                    WorkedDays = value;
                }
                else
                {
                    throw new Exception("[0-31]");
                }

            }
        }

        public abstract void Display();
        public abstract int CalcSalary();

        public void input()
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
                    fullname = Console.ReadLine().Trim();
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
        public override string ToString()
        {
            return string.Format($"id:{pID}, name:{fullname}, salary:{pSalary}, worked days:{pDays}");
        }
    }
}
