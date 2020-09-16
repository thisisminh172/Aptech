using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program m = new Program();
            
            menu();

        }

        Employee[] ds;
        static int max = 2;
        int cnt;

        public Program()
        {
            ds = new Employee[max];
            cnt = 0;
        }

        public void add()
        {
            if (cnt < max)
            {
                Employee e = new Employee();
                e.input();
                ds[cnt] = e;
                cnt++;
                return;
            }
            Console.WriteLine("HT khong con cho chua!!!");
        }

        public void display()
        {
            if (cnt > 0)
            {
                foreach(var e in ds)
                {
                    e.print();
                }
            }
            else
            {
                Console.WriteLine("HT chua co du lieu");
            }
        }

        public void display(string sName)
        {
            Console.Write("Thong tin nhan vien: ");
            //string name = sName;
            foreach(Employee e in ds)
            {
                if (e.name.Equals(sName))
                {
                    e.print();
                    return;
                }
            }
        }

        public void display(int iSalary)
        {
            Console.WriteLine($"danh sach nhan vien co muc luong tren: {iSalary}");
            foreach(Employee e in ds)
            {
                if(e.baseSalary > iSalary)
                {
                    e.print();

                }
            }
        }

        static void menu()
        {
            Program p = new Program();
            Console.WriteLine($"CT chi chua duoc {max} nhan vien");
            while (true)
            {
                Console.WriteLine("---MENU---");
                Console.WriteLine("1. Them nhan vien moi");
                Console.WriteLine("2. In toan bo danh sach nhan vien");
                Console.WriteLine("3. Tim nhan vien theo ten");
                Console.WriteLine("4. In sach nhan vien theo muc luong");
                Console.WriteLine("5. Exit");
                Console.Write("Nhap chuc nang can thuc hien: ");
                string op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1":
                        p.add();
                        break;
                    case "2":
                        p.display();
                        break;
                    case "3":
                        Console.Write("Nhap ten nhan vien can tim: ");
                        string name = Console.ReadLine().Trim();
                        p.display(name);
                        break;
                    case "4":
                        Console.Write("Nhap muc luong: ");
                        int salary = int.Parse(Console.ReadLine().Trim());
                        p.display(salary);
                        break;
                    case "5":
                        Console.WriteLine("Ket thuc CT");
                        return;
                    default:
                        Console.WriteLine("Ma so khong hop le");
                        break;
                }
            }
        }

    }
}
