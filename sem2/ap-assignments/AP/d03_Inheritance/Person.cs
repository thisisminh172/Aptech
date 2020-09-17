using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03_Inheritance
{
    public class Person
    {
        public string id, name;
        public bool gender;

        public Person()
        {
            id = "01";
            name = "Nguyen Van A";
            gender = true;
        }
         
        public override string ToString() //giong fortmat ben java     --nhấn: ov va thêm dấu space chọn toTring
        {
            var s = gender ? "nam" : "nu";
            return string.Format($"{id},{name},{s}");
        }
        // nhap thong tin ca nhan
        virtual public void input()
        {
            Console.WriteLine(">> Nhap thong tin ca nhan");
            Console.Write("id:");
            id = Console.ReadLine();
            Console.Write("nhap ten:");
            name = Console.ReadLine().Trim();

            string s = null;
            while (true)
            {
                Console.Write("nhap gioi tinh (nam|nu):");
                s = Console.ReadLine().Trim().ToLower();
                if (s == "nam")
                {
                    gender = true;
                }
                else if ( s == "nu")
                {
                    gender = false;
                }
                else
                {
                    continue;
                }
                break;
            }

        }

        virtual public void Output()
        {
            Console.WriteLine("Thong tin ca nhan");
            Console.WriteLine($"id:{id}");
            Console.WriteLine($"name:{name}");
            Console.WriteLine($"gender:{gender}");
        }
    }
}
