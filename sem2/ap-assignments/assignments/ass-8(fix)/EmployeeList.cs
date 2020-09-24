using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections;


namespace ass_8_fix_
{
    public class EmployeeList:IEnumerable<Engineer>
    {
        event DValid eEmpty;
        List<Engineer> eList;
        public EmployeeList()
        {
            eList = new List<Engineer>();
            eEmpty = new DValid(EmptyList);
        }
        public void remove(string id)
        {
            if (eList.Count == 0)
            {
                eEmpty("ko co nhan vien");
                return;
            }
            var x = (from item in eList
                     where item.pID == id
                     select item).SingleOrDefault();
            //lambda
            //var x = eList.Where(item => item.pID == id).FirstOrDefault();
            if (x != null)
            {
                eList.Remove(x);
                Console.WriteLine("remove successful");
            }
            else
            {
                eEmpty("remove failed");
            }

        }
        public Engineer Add
        {
            set
            {
                eList.Add(value);
            }
        }
        
        public void EmptyList(string s)
        {
            throw new Exception(s);
            //Console.WriteLine(s);
        }

        public IEnumerator<Engineer> GetEnumerator()
        {
            if (eList.Count == 0)
            {
                eEmpty("ko co nhan vien");
            }
            foreach (var item in eList)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            if (eList.Count == 0)
            {
                eEmpty("ko co nhan vien");
            }
            foreach (var item in eList)
            {
                yield return item;
            }
        }
    }
}
