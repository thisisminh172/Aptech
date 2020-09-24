using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_9
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
            StudentCollection c = new StudentCollection();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("*** MENU ***");
                Console.WriteLine("1. Add new student");
                Console.WriteLine("2. Print all student");
                Console.WriteLine("3. Print all passed student");
                Console.WriteLine("4. Search by Name");
                Console.WriteLine("5. Remove a studnet by ID");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your option: ");
                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1":
                        c.add();
                        break;
                    case "2":
                        Console.WriteLine("Student list");

                        foreach (Student item in c)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case "3":
                        Console.WriteLine("passed students");
                        foreach (Student item in c)
                        {
                            if (item.pAvg >= 40)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;
                    case "4":
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine().Trim();
                        foreach (Student item in c)
                        {
                            if (item.fullname.Contains(name))
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;
                    case "5":
                        Console.Write("Enter patient id to remove: ");
                        c.remove(Console.ReadLine().Trim());
                        break;
                    case "6":
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
