using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05_event_delegate
{
    class Program
    {
        //static int cnt;
        static void Main(string[] args)
        {
            //Program p = new Program();
            //p.demoMulticast();
            //demoDelegate();
            //==========***===========
            DemoEvent d = new DemoEvent();
            d.demo();

            Console.ReadKey();
        }
        void demoDelegate()
        {
            //cnt++;
            MyMath m = new MyMath();
            //tao 1 doi tuong thuc hien 1 bai toan cong tro
            MyDel casioAdd = new MyDel(m.Add);
            Console.WriteLine("Nhap 2 so nguyen thuc hien phep toan cong: ");
            Console.Write("Nhap so thu nhat: ");
            int n1 = int.Parse(Console.ReadLine().Trim());
            Console.Write("Nhap so thu hai: ");
            int n2 = int.Parse(Console.ReadLine().Trim());
            casioAdd(n1, n2);
        }

        void demoMulticast()
        {
            Console.Write("Nhap so thu nhat: ");
            int n1 = int.Parse(Console.ReadLine().Trim());
            Console.Write("Nhap so thu hai: ");
            int n2 = int.Parse(Console.ReadLine().Trim());
            MyMath m = new MyMath();
            //tao 1 doi tuong thuc hien 1 bai toan cong tro
            MyDel casio = new MyDel(m.Add);

            //ket hop tiep voi phep tru
            casio += m.Sub;
            //ket them phep chia
            casio += MyMath.Div;

            //cho thuc hien 3 phep toan tu doi tuong [casio]
            casio(n1, n2);
        }
    }
}
