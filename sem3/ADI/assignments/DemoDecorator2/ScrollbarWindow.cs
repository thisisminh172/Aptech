using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDecorator2
{
    class ScrollbarWindow : Decorator
    {
        String scrollbar = "scrollbar";
        public ScrollbarWindow(IComponent component) : base(component)
        {
            
        }
        override public void draw()
        {
            base.draw();
            Console.WriteLine("Draw "+scrollbar );
        }
    }
}
