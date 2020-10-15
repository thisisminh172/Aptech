using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemoPattern
{
    class DecoratorA : IComponent
    {
        private readonly IComponent _component;

        public DecoratorA(IComponent component)
        {
            _component = component;
        }
        //coi nhu ke thua phuong thuc nay tu object goc
        //neu muon ta co the ghi de bang cach thay doi noi dung cua phuong thuc nay
        public string Operation()
        {
            return _component.Operation();
        }

        //bo sung phuong thuc nay cho object goc
        public string AddBehavior()
        {
            return "This is A Decorator object";
        }
    }
}
