using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDecorator2
{
    class Window : IComponent
    {
        public void draw()
        {
            Console.WriteLine("Draw window");
        }
    }
}
