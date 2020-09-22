using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_5
{
    class ComputerCollection
    {
        SortedList<string,Computer> cList;
        public ComputerCollection()
        {
            cList = new SortedList<string, Computer>();
        }

        public void add()
        {
            Computer c = new Computer();
            while (true)
            {
                try
                {
                    Console.Write("Enter computer's id: ");
                    c.pID = Console.ReadLine().Trim();
                    break;
                }catch(Exception e)
                {
                    Console.WriteLine($"Loi: {e.Message}");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Enter computer's name: ");
                    c.pName = Console.ReadLine().Trim();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Loi: {e.Message}");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Enter computer price: ");
                    c.pUnitPrice = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Loi: {e.Message}");
                }
            }

            cList.Add(c.pID,c);
            

        }

        public void display()
        {
            if (cList.Count == 0)
            {
                Console.WriteLine(">>HT chua co data<<");
                return;
            }
            foreach (var item in cList.Values)
            {
                Console.WriteLine(item);
            }
        }

        public void DisplayHighValue()
        {
            int a = 1500;
            int c = 0;
            foreach (var item in cList.Values)
            {
                if (item.pUnitPrice >= a)
                {
                    Console.WriteLine(item);
                    c++;
                }
            }
            if (c == 0)
            {
                Console.WriteLine("Can't find the laptop have price about 1500.");
                return;
            }
        }

        public void Search(string name)
        {
            int c = 0;
            foreach (var item in cList.Values)
            {
                if (item.pName.ToLower() == name.Trim().ToLower())
                {
                    Console.WriteLine(item);
                    c++;
                }
            }
            if (c == 0)
            {
                Console.WriteLine($"Can't find The {name} Of Laptop ");
                return;
            }
        }
    }
}
