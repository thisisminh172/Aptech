using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //demo1();
            //demo2();
            demo3();
            Console.ReadKey();
        }

        static void demo1()
        {
            Person p = new Person();
            Console.WriteLine($"Thong tin ca nhan:{p}");

            Person p2 = new Person() { id = "02", name = "Lam", gender = true };
            Console.WriteLine($"Thong tin ca nhan:{p2}");
        }

        static void demo2()
        {
            Employee e1 = new Employee() { id = "E1", name = "Bui Quoc Tuan", gender = false ,position = "Director", salary = 1 };
            Console.WriteLine($"Thong tin nhan vien:{e1}");
        }

        static void demo3()
        {
            Student s1 = new Student() { id = "S1", name = "Nguyen Xuan Huy", gender = true, batchNo = "1910.M1", mark = 72 };
            Console.WriteLine($"Thong tin sinh vien:{s1}");

            Student s2 = new Student();
            s2.input();
            Console.WriteLine($"Thong tin sinh vien:{s2}");
            s2.Output();
        }
    }
}
