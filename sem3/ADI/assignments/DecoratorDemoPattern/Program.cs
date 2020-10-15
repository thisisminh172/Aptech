using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string Title = "DECORATOR DESIGN PATTERN";
            IComponent orgComponent = new Component();
            DecoratorA aComponent = new DecoratorA(orgComponent);
            DecoratorB bComponent = new DecoratorB(orgComponent);
            DecoratorA abComponent = new DecoratorA(bComponent);
            Console.WriteLine(Title);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Original Object: {orgComponent.Operation()}, {aComponent.AddBehavior()}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"B Decorator object: {bComponent.Operation()}");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"AB Decorator object: {abComponent.Operation()}");
            Console.ReadKey();
        }
    }
}
