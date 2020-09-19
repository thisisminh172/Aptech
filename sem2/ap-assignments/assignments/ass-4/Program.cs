using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;

namespace ass_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program m = new Program();
            m.menu();
            Console.ReadKey();
        }
        ATMAccount Acc;
        int Amount;
        public void menu()
        {
            string op = "";
            Acc = new ATMAccount();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("---MENU---");
                Console.WriteLine("1. Deposit Cash");
                Console.WriteLine("2. Withdraw Cash");
                Console.WriteLine("3. Balance");
                Console.WriteLine("4. Exit");
                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1":
                        Console.Write("Enter the amount you want to deposit: ");
                        Amount = int.Parse(Console.ReadLine().Trim());
                        Acc.pDeposit = Amount;
                        break;
                    case "2":
                        Console.Write("Enter the amount you want to withdraw: ");
                        Amount = int.Parse(Console.ReadLine().Trim());
                        Acc.pWithdraw = Amount;
                        break;
                    case "3":
                        Console.WriteLine($"Your account balance: { Acc.pBalance}");
                        break;
                    case "4":
                        Console.WriteLine("exit program");
                        return;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }

                Console.Write(" Bam phim bat ky de tiep tuc chuong trinh...");
                Console.ReadKey();

            }
        }
    }
}
