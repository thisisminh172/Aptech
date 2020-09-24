using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ass_8
{
    public delegate void DValid(string s);
    public abstract class Employee
    {
        event DValid eValid = new DValid(Validate);
        private string id, fullname;
        private int BaseSalary, WorkedDays;
        
        public string pID
        {
            get { return id; }
            set
            {
                
                    if (Regex.IsMatch(value, "^E\\d{4}$"))
                    {
                        id = value;
                    }
                    else
                    {
                        eValid("Exxxx");
                    }
                
            }
        }

        public string pName
        {
            get { return fullname; }
            set
            {

                if (Regex.IsMatch(value, "^[a-z A-Z]{1,}$"))
                {
                    fullname = value;
                }
                else
                {
                    eValid("not null");
                }

            }
        }

        public int pSalary
        {
            get { return BaseSalary; }
            set
            {

                if (value>=100 & value <= 5000)
                {
                    BaseSalary = value;
                }
                else
                {
                    eValid("[100-5000]");
                }

            }
        }

        public int pDays
        {
            get { return WorkedDays; }
            set
            {

                if (value >= 0 & value <= 31)
                {
                    WorkedDays = value;
                }
                else
                {
                    eValid("[0-31]");
                }

            }
        }

        public static void Validate (string s)
        {
            throw new Exception(s);
        }

        public abstract void display();

        public abstract void input();
        public override string ToString()
        {
            return string.Format($"{id}, {fullname}, {BaseSalary}, {WorkedDays}");
        }
    }
}
