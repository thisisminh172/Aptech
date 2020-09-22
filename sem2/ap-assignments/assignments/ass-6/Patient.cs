using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ass_6
{
    public class Patient
    {
        string id, name, contact, gender;
        //bool gender;
        int yob;
        int now_year = int.Parse(DateTime.Now.Year.ToString());
        public string pID
        {
            get { return id; }
            set
            {
                if (Regex.IsMatch(value, "^P\\d{5}$"))
                {
                    id = value;
                }
                else
                {
                    throw new Exception("Format: Pxxxxx, x is number");
                }
            }
        }

        public string pName
        {
            get { return name; }
            set
            {
                if (value.Length >= 2 && value.Length <= 30)
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Name must at least 2 char and not excess 30");
                }
            }
        }
        public string pGender
        {
            get { return gender; }
            set
            {
                if (value.ToLower().Equals("male") || value.ToLower().Equals("female"))
                {
                    gender = value;
                }
                else
                {
                    throw new Exception("must be male or female");
                }
            }
        }

        public int pYOB
        {
            //get { return yob; }
            set
            {
                
                if (value >= 1900 && value <= now_year)
                {
                    yob = value;
                }
                else
                {
                    throw new Exception("Year must be from 1900 to now");
                }
            }
        }

        public string pContact
        {
            get { return contact; }
            set
            {
                if (value.Length > 0)
                {
                    contact = value;
                }
                else
                {
                    throw new Exception("Can not be empty");
                }
            }
        }

        public int pAge
        {
            get { return now_year - yob; }
        }

        public Patient() { }
        public void accept()
        {
            while (true)
            {
                try
                {
                    Console.Write("enter patient's id: ");
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
                    Console.Write("enter patient's name: ");
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
                    Console.Write("enter patient's gender: ");
                    pGender = Console.ReadLine().Trim();
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
                    Console.Write("enter patient's yob: ");
                    pYOB = int.Parse(Console.ReadLine().Trim());
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
                    Console.Write("enter patient's contact: ");
                    pContact = Console.ReadLine().Trim();
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
            return string.Format($"{pID}, {pName}, {pGender}, {pAge}, {pContact}");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{pID}, {pName}, {pGender}, {pAge}, {pContact}");
        }
    }
}
