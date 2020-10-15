using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDecorator2
{
    class IconWindow : Decorator
    {
        string icon = "icon";
        public IconWindow(IComponent component) : base(component)
        {
        }
        public override void draw()
        {
            base.draw();
            Console.WriteLine("Draw "+ icon);
        }
    }
}
