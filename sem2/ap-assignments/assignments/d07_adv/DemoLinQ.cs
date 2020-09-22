using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d07_adv
{
    public class DemoLinQ
    {
        List<Product> ds = new List<Product>
        {
            new Product{id =1, name="coca cola", co ="US", price = 10,qoh = 202},
            new Product{id =2, name="pepsi cola", co ="Indo", price = 7,qoh = 204},
            new Product{id =3, name="banh mi", co ="VN", price = 12,qoh = 123},
            new Product{id =4, name="burger", co ="US", price = 15,qoh = 2000},
            new Product{id =5, name="banana", co ="VN", price = 2,qoh = 400},
            new Product{id =6, name="coconut", co ="ML", price = 5,qoh = 35},
            new Product{id =7, name="Beer", co ="GM", price = 45,qoh = 500}

        };

        internal void Display()
        {
            Console.WriteLine("\nDanh sach san pham: ");
            var x = from item in ds 
                    orderby item.co, item.price descending
                    select item;
            foreach(var i in x)
            {
                Console.WriteLine("\t"+i);
            }

        }

        internal void display(string pname)
        {
            var x = from item in ds
                    where item.name.Contains(pname)
                    orderby item.price
                    select item;
            foreach (var i in x)
            {
                Console.WriteLine("\t" + i);
            }
        }

        internal void DisplayGroup()
        {
            var x = from item in ds
                    group item by item.co;
            foreach(var gr in x)
            {
                Console.WriteLine($"\n CO: {gr.Key}");
                foreach(var pro in gr)
                {
                    Console.WriteLine($"{pro.id}, {pro.name}, {pro.price}");
                }
            }
        }


    }
}
