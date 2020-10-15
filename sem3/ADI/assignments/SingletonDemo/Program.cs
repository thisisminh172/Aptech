using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SINGLETON DESIGN PATTERN";
            Console.WriteLine($"Start: {Singleton._instance.Count}");
            Singleton._instance.increase();
            Console.WriteLine($"First increase: {Singleton._instance.Count}");
            Singleton._instance.increase();
            Console.WriteLine($"Second increase: {Singleton._instance.Count}");
            Console.ReadKey();
        }
    }
}
