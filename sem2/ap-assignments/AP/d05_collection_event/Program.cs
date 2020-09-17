using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05_collection_event
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
            Console.ReadKey();
        }
        static void menu()
        {
            StudentCatalogEvent sc = new StudentCatalogEvent();
            string op = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- MENU EVENT ---");
                Console.WriteLine("1. Them sinh vien moi");
                Console.WriteLine("2. In danh sach");
                Console.WriteLine("3. Thoat");
                Console.Write("Nhap lua chon: ");
                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1":
                        sc.add();
                        break;
                    case "2":
                        sc.display();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("luu chon khong hop le [1-3]");
                        break;
                }

                Console.Write(" Bam phim bat ky de tiep tuc chuong trinh...");
                Console.ReadKey();
            }
        }
    }
}
