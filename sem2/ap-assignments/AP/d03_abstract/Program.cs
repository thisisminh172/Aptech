using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            
        }

        static void Menu()
        {
            ShapeCollection sc = new ShapeCollection();
            string op = "";
            while (true)
            {
                Console.Clear();//lenh xoa man hinh

                Console.WriteLine("===Menu===");
                Console.WriteLine("1 Them hinh tron");
                Console.WriteLine("2 Them hinh chu nhat");
                Console.WriteLine("3 In toan bo doi tuong hinh hoc");
                Console.WriteLine("4.In hinh tron");
                Console.WriteLine("5.In hinh chu nhat");
                Console.WriteLine("6.Thoat");
                Console.Write("Nhap ma so chuc nang muon thuc hien[1-6]:");
                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case"1":
                        sc.addCircle();
                        break;
                    case "2":
                        sc.addRect();
                        break;
                    case "3":
                        sc.Display();
                        break;
                    case "4":
                        sc.Display(1);
                        break;
                    case "5":
                        sc.Display(2);
                        break;
                    case "6":
                        return;
                    default:
                        break;
                }
                Console.WriteLine("Bam phim bat ky....");
                Console.ReadKey();
            }
        }
    }
}
