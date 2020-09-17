using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d02_ClassMethod
{
    public class MethodDemo
    {
        //giai phuong trinh bac 2: ax2 +bx+c =0
        public bool GiaiPT2(int a, int b, int c,ref double x1,ref double x2)
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                return false;
            }
            else if(delta == 0){
                x1 = x2 = -b / (2 * a);
            }
            else
            {
                delta = Math.Sqrt(delta);
                x1 = (-b - delta) / (2 * a);
                x2 = (-b + delta) / (2 * a);
            }
            return true;
        }
    }
}
