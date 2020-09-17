using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05_collection_event
{
    
    class StudentCatalogEvent
    {
        List<StudentEvent> ds = new List<StudentEvent>();

        public void add()
        {
            StudentEvent sv = new StudentEvent();
            //nhap id cua sinh vien>>>>>>>>>>>>>
            while (true)
            {
                try
                {
                    Console.Write("Nhap id: ");
                    sv.pID = Console.ReadLine().Trim();
                    if (ds.Find(item => item.pID==sv.pID) != null)
                    {
                        throw new Exception("ID da ton tai. Vui long nhap lai !");
                    }

                    //luu sinh vien moi vo ds
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Loi: {e.Message}");
                }
            }
            //ket thuc nhap id<<<<<<<<<<<<<<<<<
            //nhap ten sinh vien>>>>>>>>

            while (true)
            {
                try
                {
                    Console.Write("Nhap ten sinh vien: ");
                    sv.pName = Console.ReadLine().Trim();

                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Loi: {e.Message}");
                }
            }
            //key thuc nhap ten<<<<<<<<<<<<<<

            //nhap diem thi>>>>>>>>

            while (true)
            {
                try
                {
                    Console.Write("Nhap diem sinh vien: ");
                    sv.pMark = int.Parse(Console.ReadLine().Trim());

                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Loi: {e.Message}");
                }
            }
            //key thuc nhap diem<<<<<<<<<<<<<<

            ds.Add(sv);

        }

        public void display()
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien trong HT");
                return;
            }

            Console.WriteLine(">> Danh sach sinh vien <<");
            foreach (var item in ds)
            {
                Console.WriteLine(item);
            }
        }
    }
}
