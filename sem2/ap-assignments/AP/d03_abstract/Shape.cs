using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03_abstract
{
    public abstract class Shape
    {
        //phuong thuc truu tuong tinh dien tich 1 doi tuong hinh hoc
        public abstract float Area();      //khi la abstract thì ko cần virtual
        //phuong thuc truu tuong tinh chu vi 1 dt hinh hoc
        public abstract float Peripheral();
        // Hang so PI
        public const float PI = 3.14f;

        public override string ToString()
        {
            return string.Format($"Dien Tich:{Area()},Chu Vi:{Peripheral()}");
        }
    }
}
