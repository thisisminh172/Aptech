using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03_Inheritance
{
    public class Student:Person
    {
        public string batchNo;
        public float mark;

        sealed public override void input()//sealed làm cho các lớp con cua student ko thể kế thừa từ hàm này
        {
            base.input();
            Console.Write("nhap ma lop hoc:");
            batchNo = Console.ReadLine().Trim();
            Console.Write("nhap diem cuoi khoa:");
            mark = float.Parse(Console.ReadLine().Trim());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"batchNo:{batchNo}");
            Console.WriteLine($"mark:{mark}");
        }

        public override string ToString()
        {
            var s = gender ? "nam" : "nu";
            return string.Format($"{id},{name},{s},{batchNo},{mark}");
        }


    }
}
