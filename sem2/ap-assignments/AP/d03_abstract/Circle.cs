using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03_abstract
{
    public class Circle:Shape
    {
        public float r;

        public void input()
        {
            Console.WriteLine("Nhap BK:");
            r = float.Parse(Console.ReadLine().Trim());
        }
        public override float Area()
        {
            return PI * r * r;
        }
        public override float Peripheral()
        {
            return 2 * PI * r;
        }
    }
}
