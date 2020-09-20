using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace d06_generic
{
    class DemoIterator : IEnumerable
    {
        string[] tensv = { "Lam", "MInh", "Duong", "Tuan", "Chuan", "Chinh", "Huy" };
        int[] diem = { 81, 80, 90, 82, 76, 56, 97 };


        public IEnumerator GetEnumerator()
        {
            foreach (var item in tensv)
            {
                yield return item;
            }
        }
    }
}
