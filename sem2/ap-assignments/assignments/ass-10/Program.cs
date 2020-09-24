using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Program m = new Program();
            m.menu();
            Console.ReadKey();
        }

        public void menu()
        {
            string op = "";
            EmployeeCatalog c = new EmployeeCatalog();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("*** MENU ***");
                Console.WriteLine("1. Add new Engineer");
                Console.WriteLine("2. Print all Engineer");
                Console.WriteLine("3. display all senior engineer");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your option: ");
                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1":
                        c.add();
                        break;
                    case "2":
                        c.displayAll();
                        break;
                    case "3":
                        Console.WriteLine("senior engineer list");
                        c.GetSenior();
                        break;

                    case "4":
                        Console.WriteLine("Exit program");
                        return;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
                Console.WriteLine("Bam phim bat ky....");
                Console.ReadKey();
            }
        }
        
    }
}
