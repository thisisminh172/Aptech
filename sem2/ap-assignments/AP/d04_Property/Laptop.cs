using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d04_Property
{
    public class Laptop
    {
        public string id { get; set; }//auto -implement property
        public string name { get; set; }
        public int qoh { get; set; }
        public override string ToString()
        {
            return string.Format($"{id}, {name}, {qoh}");
        }
    }

    public class Inventory
    {
        Dictionary<string,Laptop> ds = new Dictionary<string,Laptop>();

        //tao indexer tham chieu ds.
        public Laptop this[string id]
        {
            get
            {
                return ds[id];
            }
            set
            {
                ds.Add(value.id, value);
            }
        }

        public void display()
        {
            if (ds.Count==0)
            {
                Console.WriteLine("HT chua co du lieu");
                return;
            }

            Console.WriteLine("danh sach Laptop");
            foreach(var item in ds.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
