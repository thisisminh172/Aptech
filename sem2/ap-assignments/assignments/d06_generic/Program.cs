using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d06_generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoGen d = new DemoGen();
            //d.test();
            Program t = new Program();
            //t.testMethodGeneric();
            t.TestIterator();
            Console.ReadKey();
        }

        public void Display<T>(T[] a, string s)
        {
            Console.WriteLine("Danh sach "+ s );
            foreach(var item in a)
            {
                Console.WriteLine($"\t{ item}");
            }
        }

        public void testMethodGeneric()
        {
            string[] tensv = { "Gia lam", "Ngoc thach", "Van Thang" };
            int[] diem = { 82, 67, 65 };
            Display<string>(tensv, "Ten sinh vien");
            Display<int>(diem, "diem project");

        }

        public void TestIterator()
        {
            DemoIterator demo = new DemoIterator();

            Console.WriteLine("Danh sach sinh vien: " );
            foreach (var item in demo)
            {
                Console.WriteLine($"\t{item}");
            }
        }
    }

    
}
