using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_8
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
            EmployeeList c = new EmployeeList();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("*** MENU ***");
                Console.WriteLine("1. Add new Engineer");
                Console.WriteLine("2. remove an Engineer by id");
                Console.WriteLine("3. Print all Engineer");
                Console.WriteLine("4. display all senior engineer");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your option: ");
                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1":
                        c.Add();
                        break;
                    case "2":
                        Console.Write("Enter id you want to delete: ");
                        string id = Console.ReadLine().Trim();
                        c.remove(id);
                        break;
                    case "3":
                        Console.WriteLine("engineer list");

                        foreach (var item in c)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    
                    case "4":
                        Console.WriteLine("senior engineer: ");
                        foreach (Engineer item in c)
                        {
                            if (item.CalcSalary()>2000)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;
                    case "5":
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
