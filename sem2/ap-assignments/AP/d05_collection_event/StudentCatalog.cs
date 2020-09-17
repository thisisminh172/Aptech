using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05_collection_event
{
    public class StudentCatalog
    {
        SortedList<string, Student> ds = new SortedList<string, Student>();

        //ham them sinh vien moi
        public void add()
        {
            Student sv = new Student();
            //nhap id cua sinh vien>>>>>>>>>>>>>
            while (true)
            {
                try
                {
                    Console.Write("Nhap id: ");
                    sv.pID = Console.ReadLine().Trim();
                    if (ds.ContainsKey(sv.pID))
                    {
                        throw new Exception("ID da ton tai. Vui long nhap lai !");
                    }

                    //luu sinh vien moi vo ds
                    break;
                }catch(Exception e)
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
                catch(Exception e)
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

            ds.Add(sv.pID, sv);

        }

        //in danh sach sinh vien
        public void display()
        {
            if(ds.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien trong HT");
                return;
            }

            Console.WriteLine(">> Danh sach sinh vien <<");
            foreach(var item in ds.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
