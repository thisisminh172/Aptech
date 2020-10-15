using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemoPattern
{
    class DecoratorB : IComponent
    {
        private readonly IComponent _component;

        public DecoratorB(IComponent component)
        {
            _component = component;
        }
        public string Operation()
        {
            var s = _component.Operation();
            return $"{s}. But I was override";

        }
    }
}
