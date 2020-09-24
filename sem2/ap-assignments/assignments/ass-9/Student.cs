using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using System.Threading.Tasks;

namespace ass_9
{
    public delegate void DMess(string s);
    public class Student
    {
        private string id;
        private int maths, english;
        public string fullname;
        public event DMess EMess;
        public Student()
        {
            EMess = new DMess(ValidProcess);
        }
        public string pID
        {
            get { return id; }
            set
            {
                if (Regex.IsMatch(value, "^ST-\\d{3,5}$"))
                {
                    id = value;
                }
                else
                {
                    EMess("ST-xxx[xx]");
                }
            }
        }
        public int pMath
        {
            set
            {
                if (value>=0 && value <= 100)
                {
                    maths = value;
                }
                else
                {
                    EMess("[0-100]");
                }
            }
        }
        public int pEnglish
        {
            set
            {
                if (value >= 0 && value <= 100)
                {
                    english = value;
                }
                else
                {
                    EMess("[0-100]");
                }
            }
        }

        public int pAvg
        {
            get
            {
                return (maths + english) / 2;
            }
        }


        public override string ToString()
        {
            return string.Format($"id:{id}, fullname: {fullname}, math: {maths}, english: {english}, avg: {pAvg}");
        }
        public void display()
        {
            Console.WriteLine(this);
        }
        public static void ValidProcess(string s)
        {
            throw new Exception($"Error: {s}");
        }
    }
}
