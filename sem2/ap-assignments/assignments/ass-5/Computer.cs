using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ass_5
{
    public delegate void DValid(string s);
    class Computer
    {
        event DValid Evalid;
        string id, name;
        int unitPrice;
        public Computer()
        {
            Evalid = new DValid(showMessage);

        }

        public string pID
        {
            get { return id; }
            set
            {
                if (Regex.IsMatch(value, "^C\\d{3,5}$"))
                {
                    id = value;
                }
                else
                {
                    Evalid("Sai format Cxxx[xx]");
                }
            }
        }

        public string pName
        {
            get { return name; }
            set
            {
                if (Regex.IsMatch(value, "^[a-zA-z 0-9]{3,}$"))
                {
                    name = value;
                }
                else
                {
                    Evalid("at least 3 char");
                }
            }
        }

        public int pUnitPrice
        {
            get { return unitPrice; }
            set
            {
                if (value >= 100 && value <= 3000)
                {
                    unitPrice = value;
                }
                else
                {
                    Evalid("the number must between 100-3000");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("id: {0}, name: {1}, unit price: {2}",pID,pName, unitPrice);
        }
        public void showMessage(string s)
        {
            Console.WriteLine(s);
        }
    }
}
