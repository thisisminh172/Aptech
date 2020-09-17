using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05_event_delegate
{
    //dinh nghia delegate : ham void MyDel co 2 tham so nguyen, kieu gia tri tro ve la void
    public delegate void MyDel(int num1, int num2);
    public class MyMath
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a+b}");
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
        public static void Div(int a, int b)
        {
            try
            {
                Console.WriteLine($"{a} / {b} = {a / b}");

            }catch(Exception e)
            {
                Console.WriteLine("Loi sai: " + e.Message);
            }
        }
    }
}
