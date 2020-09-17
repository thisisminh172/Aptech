using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_3
{
    class StudentPremium : Student
    {
        int markofObj, markofPrac;
        public int pMarkOfObj
        {
            get
            {
                return markofObj;
            }
            set
            {
                markofObj = value;
            }
        }
        public int pMarkOfPrac
        {
            get
            {
                return markofPrac;
            }
            set
            {
                markofPrac = value;
            }
        }
        public override void accept()
        {
            Console.Write("Input student's id: ");
            id = Console.ReadLine().Trim();
            Console.Write("Input student's fullname: ");
            fullname = Console.ReadLine().Trim();
            Console.Write("Input student's dob: ");
            dob = Console.ReadLine().Trim();
            Console.Write("Input student's gender[0-female, 1-male]: ");
            string ans = Console.ReadLine().Trim();
            gender = ans == "1" ? true : false;
            Console.Write("Input student's mark of obj: ");
            markofObj = int.Parse(Console.ReadLine().Trim());
            Console.Write("Input student's mark of prac: ");
            markofPrac = int.Parse(Console.ReadLine().Trim());
        }

        public override void print()
        {
            Console.WriteLine($"Student's id: {id} ");
            Console.WriteLine($"Student's fullname: {fullname} ");
            Console.WriteLine($"Student's dob: {dob} ");
            Console.WriteLine($"Student's gender: {gender} ");
            Console.WriteLine($"Studnet's avg: {(markofObj + markofPrac) / 2}");
            
        }
    }
}
