using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d01_test_unicode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.InputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            string fname;
            Console.Write("Nhập tên của bạn: ");
            fname = Console.ReadLine().Trim();
            Console.WriteLine("Tên của bạn là: "+fname);
            Console.ReadKey();

        }
    }
}
