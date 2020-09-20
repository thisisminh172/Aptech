using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d06_generic
{
   //dinh nghia lop generic Student co 2 tham so kieu du lieu A va B
    public class Student<A,B>
    {
        public A id;
        public string name;
        public B gender;

        public override string ToString()
        {
            return string.Format($"{id}, {name}, {gender}");
        }
    }

    public class DemoGen
    {
        public void test()
        {
            Student<int, bool> sv1 = new Student<int, bool>()
            {
                id = 100,
                name = "Le Minh",
                gender = true
            };
            Student<string, int> sv2 = new Student<string, int>()
            {
                id = "SV100",
                name = "Nga Do",
                gender = 1,
            };

            Student<string, string> sv3 = new Student<string, string>()
            {
                id = "SV101",
                name = "Nga Do",
                gender = "female",
            };

            StudentAptech<string, string, string> sv4 = new StudentAptech<string, string, string>()
            {
                id = "student123",
                name = "Le MInh",
                gender = "nam",
                grade = "A+"
            };

            StudentAptech<int, bool, int> sv5 = new StudentAptech<int, bool, int>()
            {
                id = 123,
                name = "MInh MInh",
                gender = false,
                grade = 75
            };

            Console.WriteLine($"Thong tin sinh vien: \n {sv1} \n {sv2} \n {sv3} \n {sv4} \n {sv5}");
        }
    }

    //dinh nghia lop con generic co them tham so kieu du lieu C
    public class StudentAptech<A, B, C> : Student<A, B>
    {
        public C grade;
        public override string ToString()
        {
            return string.Format($"{id}, {name}, {gender}, {grade}");
        }
    }
}
