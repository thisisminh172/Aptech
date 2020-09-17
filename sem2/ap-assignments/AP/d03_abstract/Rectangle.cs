using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03_abstract
{
    public class Rectangle : Shape
    {

        public float h;
        public float w;
        public void Input()
        {
            
            Console.Write("Nhap chieu dai:");
            h = float.Parse(Console.ReadLine().Trim());
            Console.Write("Nhap chieu rong:");
            w = float.Parse(Console.ReadLine().Trim());
        }
        public override float Area()
        {
            return w * h; 
        }

        public override float Peripheral()
        {
            return (w + h) / 2;
        }
    }
}
