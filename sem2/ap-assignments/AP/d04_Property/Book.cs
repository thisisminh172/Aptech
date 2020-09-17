using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d04_Property
{
    public class Book
    {
        public string id, title;
        public int price;

        public Book() { }
        public Book(string id, string title, int price)
        {
            this.id = id;
            this.title = title;
            this.price = price;
        }

        public override string ToString()
        {
            return string.Format($"{id}, {title}, {price}");
        }

    }

    public class BookCatalog
    {
        List<Book> ds = new List<Book>();
        //dn write-only property pLIB, luu cac quyen sach vo bien [ds]

        public Book pLIB
        {
            set
            {
                ds.Add(value);
            }
        }

        //dn read-only property count, tra ve tong so sach trong [ds]
        public int pCount
        {
            get
            {
               return ds.Count;
            }
        }

        //phuong thuc in toan bo sach trong [ds]
        public void Display()
        {
            if(pCount == 0)
            {
                Console.WriteLine("he thong chua co du lieu");
                return;

            }
            Console.WriteLine("danh muc sach");
            foreach(var item in ds)
            {
                Console.WriteLine(item);
            }
        }
    }
}
