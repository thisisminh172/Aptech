using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d02_ClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //demo phuong trinh bac 2
            int a, b, c;
            Console.WriteLine("Giai phuong trinh Bac 2: ax2 + bx +c =0");
            Console.Write("Nhap he so a: ");
            a = int.Parse(Console.ReadLine().Trim());
            Console.Write("Nhap he so b: ");
            b = int.Parse(Console.ReadLine().Trim());
            Console.Write("Nhap he so c: ");
            c = int.Parse(Console.ReadLine().Trim());
            double x1 =0 , x2 =0;
            MethodDemo md = new MethodDemo();
            bool r = md.GiaiPT2(a, b, c,ref x1,ref x2);
            if (r)
            {
                Console.WriteLine("Phuong trinh co nghiem");
                Console.WriteLine("x1 = {0},x2 = {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
        }


    }
}
