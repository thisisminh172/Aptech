using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace d03_abstract
{
    public class ShapeCollection
    {
        // dn 1 danh sach cac doi tuong hinh hoc
        List<Shape> ds = new List<Shape>();
        //phuong thuc them 1 hinh chu nhat zo ds
        public void addRect()
        {
            Rectangle r = new Rectangle();
            r.Input();

            ds.Add(r);

        }

        public void addCircle()
        {
            Circle c = new Circle();
            c.input();

            ds.Add(c);

        }
         //Phuong thuc in ra tat ca cac doi tuong hinh hoc
        public void Display()
        {
            //kiem tra phan tu
            if (ds.Count == 0)
            {
                Console.WriteLine(">>He thong chua co du lieu");
                return;
            }
            Console.WriteLine("\n Danh sach cac doi tuong hinh hoc");
            foreach (var item in ds)
            {
                Console.WriteLine(item);
            }
        }

        //phuong thuc in tat ca cac doi tuong HH theo tham so
        public void Display(int n)
        {
            //kiem tra phan tu
            if (ds.Count == 0)
            {
                Console.WriteLine(">>He thong chua co du lieu");
                return;
            }
            if (n == 1)
            {
                Console.WriteLine("\n Ds cac doi tuong hinh tron:");
            }
            else
            {
                Console.WriteLine("\n Ds cac doi tuong hinh chu nhat:");
            }

            int dem = 0;
            if (n == 1)
            {
                foreach (var item in ds)
                {
                    if (item is Circle)
                    {
                        Console.WriteLine(item);
                        dem++;
                    }
                    
                }
            }
            else
            {
                foreach (var item in ds)
                {
                    if (item is Rectangle)
                    {
                        Console.WriteLine(item);
                        dem++;
                    }

                }
            }

            if (dem == 0)
            {
                Console.WriteLine("Ko tim thay");
            }
            
        }
    }
}
