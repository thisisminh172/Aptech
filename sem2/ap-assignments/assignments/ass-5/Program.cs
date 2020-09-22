using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Program m = new Program();
            m.Menu();
            Console.ReadKey();
        }
        void Menu()
        {
            string op = "";
            ComputerCollection c = new ComputerCollection();
            while (true)
            {
                Console.Clear();//lenh xoa man hinh

                Console.WriteLine("===Menu===");
                Console.WriteLine("1 Add new computer:");
                Console.WriteLine("2 Display all computers:");
                Console.WriteLine("3 Display all computers having price about 1500$:");
                Console.WriteLine("4.Search computers by name:");
                Console.WriteLine("5.Quit.");

                Console.Write("Please Enter [1-5]:");
                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1":
                        c.Add();
                        break;
                    case "2":
                        c.DisplayAll();
                        break;
                    case "3":
                        c.DisplayHighValue();
                        break;
                    case "4":
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter Computer Name:");
                                string n = Console.ReadLine();
                                //Console.WriteLine("The list of student have avg larger than avg input:");
                                c.Search(n);
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }

                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Pleaze selected 1 to 5 method");
                        break;
                }
                Console.WriteLine("Bam phim bat ky....");
                Console.ReadKey();
            }
        }
}
