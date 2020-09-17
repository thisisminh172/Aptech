using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d04_Property
{
    class Program
    {
        static void Main(string[] args)
        {

            //demoWriteOnly();
            demoIndexer();
            Console.ReadKey();
        }

        static void demoIndexer()
        {
            Laptop l1 = new Laptop()
            {
                id = "L01",
                name = "Dell",
                qoh = 10
            };
            Laptop l2 = new Laptop()
            {
                id = "L02",
                name = "HP",
                qoh = 103
            };
            Laptop l3 = new Laptop()
            {
                id = "L03",
                name = "Acer",
                qoh = 100
            };


            Inventory inv = new Inventory();
            //dua 3 doi tuong laptop vo [ds] cia doi tuong [inv] thong qua indexer
            inv[l1.id] = l1;
            inv[l2.id] = l2;
            inv[l3.id] = l3;

            inv.display();

            //tim laptop theo ma so
            Console.WriteLine("Nhap ma so Laptop can tim: ");
            string ms = Console.ReadLine().Trim();
            //lay doi tuong laptop co ma so [ms] thong qua indexer
            var lap = inv[ms];
            Console.WriteLine(lap);
        }

        static void demoWriteOnly()
        {
            BookCatalog bc = new BookCatalog();
            Book b1 = new Book();
            b1.id = "B01";
            b1.title = "Lap trinh c#";
            b1.price = 100;

            Book b2 = new Book();
            b2.id = "B02";
            b2.title = "Lap trinh java";
            b2.price = 200;

            Book b3 = new Book("B03", "SQL server", 150);
            Book b4 = new Book("Java nang cao","B04",210);
            Book b5 = new Book()
            {
                id = "B05",
                title = ".NET Framework",
                price = 220
            };

            bc.pLIB = b1;// them b1 vo [ds] cua BookCatalog [bc]
            bc.pLIB = b2;
            bc.pLIB = b3;
            bc.pLIB = b4;
            bc.pLIB = b5;
            //goi ham in danh muc sach 
            bc.Display();
        }
        static void demoProperty()
        {
            Product p = new Product();

            p.pID = "P001";
            p.pName = "coca cola 330ml";
            p.pPrice = 999;
            Console.WriteLine($"Ma so san pham: {p.pID}");
            Console.WriteLine($"Ten san pham: {p.pName}");
            Console.WriteLine($"Gia san pham: {p.pPrice}");
            Console.ReadKey();
            
        }
    }
}
