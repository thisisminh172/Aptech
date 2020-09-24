using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ass_7
{
    public class Student
    {
        string id, name;
        int maths, english;

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
                    throw new Exception("ST-xxx[xx]");
                }
            }
        }

        public string pName
        {
            get { return name; }
            set
            {
                if (Regex.IsMatch(value,"^[a-z A-Z]{1,}$"))
                {
                    name = value;
                }
                else
                {
                    throw new Exception("only char, at least 1");
                }
            }
        }

        public int pMath
        {
            set
            {
                if(value >=0 && value <= 100)
                {
                    maths = value;
                }
                else
                {
                    throw new Exception("[0-100]");
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
                    throw new Exception("[0-100]");
                }
            }
        }

        public float pAvg
        {
            get
            {
                    return (float)(maths + english) / 2;
            }
        }

        public void print()
        {
            Console.WriteLine($"id: {id},name: {name},math: {maths},eng: {english},avg: {pAvg}");
        }

        public void accept()
        {
            while (true)
            {
                try
                {
                    Console.Write("Student'id: ");
                    pID = Console.ReadLine().Trim();
                    break;
                }catch(Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Student'name: ");
                    pName = Console.ReadLine().Trim();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Math: ");
                    pMath = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("English: ");
                    pEnglish = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }

        public override string ToString()
        {
            return string.Format($"id: {id},name: {name},math: {maths},eng: {english},avg: {pAvg}");
        }


    }
}
