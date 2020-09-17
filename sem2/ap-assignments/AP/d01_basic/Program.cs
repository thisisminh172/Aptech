using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d01_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            string op = "";
            do
            {
                Console.Clear();
                Console.WriteLine("===MENU===");
                Console.WriteLine("1. Test BitWise Operators");
                Console.WriteLine("2. Test Or Operators");
                Console.WriteLine("3. Test Switch-case Operators");
                Console.WriteLine("4. Test TestLoop Operators");
                Console.WriteLine("5. exist");

                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1": TestBitWise();break;
                    case "2": TestOr();break;
                    case "3": TestSwitchCase();break;
                    case "4": TestLoop();break;
                    case "5": return;
                    default: Console.WriteLine("Wrong code,Plz try again !"); break;
                }
                Console.Write("\t Press any key to continue");
                Console.ReadKey();
            } while (true);

        }
        static void TestBitWise()
        {
            int x, y;
            Console.WriteLine("Phep toan bitwise");
            Console.Write("Nhap gia tri x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia tri y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} & {1} = {2}", x, y, x & y);

        }

        static void TestOr()
        {
            int x, y;
            Console.WriteLine("Phep toan OR");

            Console.Write("Nhap gia tri x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gia tri y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} & {1} = {2}", x, y, x|y);
        }

        static void TestSwitchCase()
        {
            Console.Clear();
            Console.Write("Nhap vao thang muon tinh so ngay [1-12]");
            int m = int.Parse(Console.ReadLine().Trim());
            int days = 0;
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    days = 29;
                    break;
                default:
                    days = -1;
                    break;

            }

            if(days == -1)
            {
                Console.WriteLine("Thang nhap khong hop le !");

            }
            else
            {
                Console.WriteLine($"Thang {m} co {days} ngay");
            }
        }

        static void TestLoop()
        {
            Console.Clear();
            Console.WriteLine("Tinh giai thua cua 1 so nguyen: ");
            int n = 0;
            while (true)
            {
                Console.Write("nhap 1 so nguyen [0-20]: ");
                n = int.Parse(Console.ReadLine().Trim());
                if (n >= 0 && n <= 20) break;
                
            }

            ulong r = 1;
            for(uint i = 1; i <= n; i++)
            {
                r = r * i;
            }

            Console.Write($"{n}! = {r}");
        }
    }
}
