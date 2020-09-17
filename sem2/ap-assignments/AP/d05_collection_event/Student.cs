using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05_collection_event
{
    public class Student
    {
        private string id, name;
        private int mark;

        //>>>>>>property cho id
        public string pID
        {
            get { return id;}
            set
            {
                if(Regex.IsMatch(value, "^SV\\d{3}$"))
                {
                    id = value;
                }
                else
                {
                    throw new FormatException("ID khong hop le!!! [SVxxx voi x la ky so]");
                }
            }
        }
        //ket thuc property cho id<<<<<<<<<
        //>>>>>>>>>property cho name
        public string pName
        {
            get { return name; }
            set
            {
                if (value.Trim().Length >=2)
                {
                    name = value;
                }
                else
                {
                    throw new FormatException("Ten khong hop le!! ten phai co it nhat 2 ky tu");
                }
            }
        }
        //ket thuc property cho name<<<<<<<
        //>>>>>>>>>property cho mark
        public int pMark
        {
            get { return mark; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    mark = value;
                }
                else
                {
                    throw new FormatException("Diem khong hop le!! [0-100]");
                }
            }
        }
        //ket thuc property cho mark<<<<<<<<

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}",id,name,mark);
        }
    }
}
