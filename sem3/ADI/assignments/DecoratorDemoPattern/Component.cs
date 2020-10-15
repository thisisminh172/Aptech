using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemoPattern
{
    class Component : IComponent
    {
        public string Operation()
        {
            return "Hello! This is the original object";
        }
    }
}
