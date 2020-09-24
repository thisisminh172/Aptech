using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ass_7
{
    public delegate void DEmpty(string s);
    public class HighSchool : IEnumerable
    {
        event DEmpty ENullData;
        List<Student> stList;
        public HighSchool()
        {
            stList = new List<Student>();
            ENullData = new DEmpty(showMessage);
        }

        public void showMessage(string s)
        {
            Console.WriteLine(s);
        }
        public void add()
        {
            Student st = new Student();
            st.accept();
            stList.Add(st);
        }

        public void remove(string id)
        {
            var x = (from item in stList
                     where item.pID == id
                     select item).SingleOrDefault();
           
            if(x != null)
            {
                stList.Remove(x);
            }
            else
            {
                Console.WriteLine("fail");
            }
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var item in stList)
            {
                yield return item;
            }
        }
    }
}
