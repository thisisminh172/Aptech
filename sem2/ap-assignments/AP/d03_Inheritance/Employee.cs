using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03_Inheritance
{
    public class Employee : Person
    {
        public string position;
        public int salary;

        public override string ToString()
        {
            var s = gender ? "nam" : "nu";
            return string.Format($"{id},{name},{s},{position},{salary}");
        }
    }
}
