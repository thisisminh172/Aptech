using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d07_adv
{
    public delegate long fnMath(int n);
    public class DemoAdv
    {

        public long Factorial(int n)
        {
            long r = 1;
            for (int i = 2; i <= n; i++)
            {
                r *= i;
            }
            return r;
        }
        public void testDelegate()
        {
            //khoi tao delegate
            fnMath fn = new fnMath(Factorial);
            Console.Write("Nhap 1 so nguyen duong >= 0 : ");
            int n = int.Parse(Console.ReadLine().Trim());
            //thuc hien tinh va in ket qua cua giai thua n
            Console.WriteLine($"{n}! = "+fn(n));

            //khoi tao 1 system generic delegate de thuc 
            Func<int, long> f = Factorial;

            //thuc hien tinh va in ket qua cua giai thua n
            Console.WriteLine($"{n}! = " + f(n));
        }
        public delegate int fnMath2(int a, int b);
        public void testLambda()
        {
            int x = 16, y = 7;
            //viet kieu nghiem tuc
            fnMath2 fn = (int a, int b) => { return a + b; };
            Console.WriteLine($"{x} + {y} = {fn(x, y)}");

            //viet kieu rut gon
            fn = (a, b) => a - b;
            Console.WriteLine($"{x} - {y} = {fn(x, y)}");

            //su dung system delegate
            Func<int,int, int> fn2 = (a, b) => a * b;
            Console.WriteLine($"{x} * {y} = {fn2(x, y)}");

            //su dung system delegate tinh giai thua
            Func<int, long> gt = n =>
             {
                 long r = 1;
                 for(int i = 2; i <=n; i++)
                 {
                     r *= i;
                 }
                 return r;
             };

            x = 7;
            Console.WriteLine($"Giai thua {x}! = {gt(x)}");


        }

    }
}
