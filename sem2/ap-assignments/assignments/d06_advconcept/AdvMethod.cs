using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace d06_advconcept
{
    public delegate void MyCasio(int a, int b);
    public class AdvMethod
    {
        public void demoAnonymous()
        {
            int a = 10,b = 6;
            //khoi tao delegate [MyCasio] voi pt an danh, thuc hien phep cong 2 so
            MyCasio casio = delegate (int x, int y)
            {
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            };

            //tiep tuc khoi tao delegate [MyCasio] voi pt an danh, thuc hien phep nhan 2 so
            casio += delegate (int x, int y)
            {
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            };

            casio(a, b);
        }
    }

    public static class ExtendString
    {
        //Ham mo rong chuc nang cho lop string
        public static string AllTrim(this string s)
        {
            string r = s.Trim();
            r = Regex.Replace(r, "\\s{2,}", " ");
            
            return r;
        }
    }
}
