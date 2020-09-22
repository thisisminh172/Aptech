using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testiterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Program m = new Program();
            m.test();
            Console.ReadKey();
        }
        public void test()
        {
            demo demo = new demo();

            Console.WriteLine("Danh sach sinh vien: ");
            foreach (var item in demo)
            {
                Console.WriteLine($"\t{item}");
            }
        }

    }
}
