using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_2
{
    class Employee
    {
        public string id, name, position;
        public int baseSalary;

        public Employee() { }
        public Employee(string id, string name, string position, int baseSalary)
        {
            this.id = id;
            this.name = name;
            this.position = position;
            this.baseSalary = baseSalary;

        }

        public void input()
        {
            Console.Write("Nhap ma so nhan vien: ");
            id = Console.ReadLine().Trim();
            Console.Write("Nhap ten nhan vien: ");
            name = Console.ReadLine().Trim();
            Console.Write("Nhap chuc vu nhan vien: ");
            position = Console.ReadLine().Trim();
            Console.Write("Nhap muc luong: ");
            baseSalary = int.Parse(Console.ReadLine().Trim());
        }
        public void print()
        {
            Console.WriteLine($"Thong tin: ma so {this.id}, ten {this.name}, chuc vu {this.position}, muc luong {this.baseSalary}");
        }
    }
}
