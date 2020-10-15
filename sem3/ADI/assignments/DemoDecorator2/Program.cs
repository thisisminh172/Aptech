using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDecorator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Decorator Pattern ---");
            IComponent iconWindow = new IconWindow(new ScrollbarWindow(new Window()));
            iconWindow.draw();
            Console.ReadKey();
        }
    }
}
