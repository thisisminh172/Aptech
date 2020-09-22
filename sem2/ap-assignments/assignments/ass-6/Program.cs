using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_6
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
            Clinic c = new Clinic();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("*** MENU ***");
                Console.WriteLine("1. Add new patient");
                Console.WriteLine("2. Print all patients");
                Console.WriteLine("3. Search by ID");
                Console.WriteLine("4. Search by Name");
                Console.WriteLine("5. Remove a patient by ID");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your option: ");
                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1":
                        c.AddNewPatient();
                        break;
                    case "2":
                        Console.WriteLine("Patient list");
                        
                        foreach(Patient item in c)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                        
                    case "3":
                        Console.Write("Enter patient id to search: ");
                        var p = c.Search(Console.ReadLine().Trim());
                        Console.WriteLine(p);
                        break;
                    case "4":break;
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
