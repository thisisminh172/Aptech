using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ass_8
{
    public class EmployeeList : IEnumerable
    {
        event DValid eEmpty;
        List<Engineer> eList;

        public EmployeeList()
        {
            eList = new List<Engineer>();
            eEmpty = new DValid(EmptyList);
        }
        public void Add()
        {
            Engineer e = new Engineer();
            e.input();
            eList.Add(e);
            Console.WriteLine("Add new successful");
        }

        public void remove(string id)
        {
            if(eList.Count == 0)
            {
                eEmpty("ko co nhan vien");
                return;
            }
            var x = (from item in eList
                     where item.pID == id
                     select item).SingleOrDefault();
            if(x != null)
            {
                eList.Remove(x);
                Console.WriteLine("remove successful");
            }
            else
            {
                eEmpty("remove failed");
            }

        }
        public IEnumerator GetEnumerator()
        {
            foreach (var item in eList)
            {
                yield return item;
            }
        }
        public void EmptyList(string s)
        {
            Console.WriteLine(s);
        }
    }
}
