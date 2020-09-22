using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d07_adv
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoAdv f = new DemoAdv();
            DemoLambda demo2 = new DemoLambda();
            DemoLinQ demo3 = new DemoLinQ();
            //f.testDelegate();
            //f.testLambda();
            //demo2.Display();
            //Console.WriteLine("Nhap ten san pham: ");
            //string name = Console.ReadLine().Trim();
            //demo2.Display(name);
            demo3.Display();
            Console.WriteLine("Nhap ten san pham: ");
            demo3.display(Console.ReadLine().Trim());
            demo3.DisplayGroup();
            Console.ReadKey();
        }
    }
}
