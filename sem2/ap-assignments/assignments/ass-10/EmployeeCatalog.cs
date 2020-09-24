using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ass_10
{
    public class EmployeeCatalog : IEnumerable
    {
        List<Engineer> eList = new List<Engineer>();

        public IEnumerator GetEnumerator()
        {
            foreach (var item in eList)
            {
                if (item.CalcSalary() >= 500)
                {
                    yield return item;
                }
            }
        }

        public void add()
        {
            Engineer e = new Engineer();
            e.input();
            eList.Add(e);
        }

        public void displayAll()
        {
            foreach(var item in eList)
            {
                item.Display();
            }
        }
        public void GetSenior()
        {
            foreach(var item in eList)
            {
                if(item.CalcSalary() >= 500)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
