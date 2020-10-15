using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDecorator2
{
    class Decorator : IComponent
    {
        IComponent component;

        public Decorator(IComponent component)
        {
            this.component = component;
        }

        virtual public void draw()
        {
            component.draw();
        }
    }
}
