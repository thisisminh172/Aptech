using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_test
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
            BookManage bm = new BookManage();
            string op = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("***MENU***");
                Console.WriteLine("1. Create new");
                Console.WriteLine("2. Find by isSale");
                Console.WriteLine("3. Find all");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your option: ");
                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1":
                        Book b = new Book();
                        bm.createBook(b);
                        break;
                    case "2":
                        Console.WriteLine("List of book is sale:");
                        bm.findByIsSale();
                        break;
                    case "3":
                        
                        foreach(Book item in bm)
                        {
                            item.bookInfo();
                        }
                        break;
                    case "4":
                        Console.WriteLine("Exit program");
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }
    }
}
