using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ass_9
{
    public class StudentCollection : IEnumerable
    {
        List<Student> stList;
        public StudentCollection()
        {
            stList = new List<Student>();
        }

        public void add()
        {
            Student st = new Student();
            while (true)
            {
                try
                {
                    Console.Write("Enter id: ");
                    st.pID = Console.ReadLine().Trim();
                    break;
                }catch(Exception e)
                {
                    Console.WriteLine($"Loi: {e.Message}");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Enter name: ");
                    st.fullname = Console.ReadLine().Trim();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Loi: {e.Message}");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Enter maths: ");
                    st.pMath = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Loi: {e.Message}");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Enter english: ");
                    st.pEnglish = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Loi: {e.Message}");
                }
            }
            stList.Add(st);
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var item in stList)
            {
                yield return item;
            }
        }

        public void search(string name)
        {
            var x = from item in stList
                     where item.fullname == name
                     select item;
            Console.WriteLine("Danh sách sinh vien:");
            foreach(var item in x)
            {
                Console.WriteLine(item);
            }
            
        }

        public void remove(string id)
        {
            var x = (from item in stList
                    where item.pID == id
                    select item).SingleOrDefault();
            stList.Remove(x);
            Console.WriteLine("Xoa thanh cong");
        }

        public void DisplayAll()
        {
            if (stList.Count == 0)
            {
                Console.WriteLine("Khong co sinh vien trong danh sach");
                return;
            }
            Console.WriteLine("student list");
            foreach(var item in stList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
