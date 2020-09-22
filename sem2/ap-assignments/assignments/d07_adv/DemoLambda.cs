using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d07_adv
{
    public class Product
    {
        public int id, price, qoh;
        public string name, co;

        public override string ToString()
        {
            return string.Format($"{id}, {name}, {co}, {price}, {qoh}");
        }

        
    }
    public class DemoLambda
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
            ds.ForEach(item => Console.WriteLine(item));

        }

        public void Display(string productName)
        {
            var x = ds.Where(item => item.name.Contains(productName)).ToList();
            if(x.Count == 0)
            {
                Console.WriteLine("ko tim thay san pham "+productName);

            }
            else
            {
                var tong = x.Sum(i => i.price * i.qoh);
                x.ForEach(item => Console.WriteLine(item));
                Console.WriteLine($"Tong tri gia ton kho: {tong}");
            }
        }
    }
}
