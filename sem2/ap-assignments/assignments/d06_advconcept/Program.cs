using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d06_advconcept
{
    class Program
    {
        static void Main(string[] args)
        {
            AdvMethod a = new AdvMethod();
            //a.demoAnonymous();
            Console.Write("Nhap chuoi ky tu: ");
            string s = Console.ReadLine();
            Console.WriteLine($"Chuoi nhap: {s}");
            Console.WriteLine($"Sau: {s.AllTrim()}");
            Console.ReadKey();
        }
    }
}
