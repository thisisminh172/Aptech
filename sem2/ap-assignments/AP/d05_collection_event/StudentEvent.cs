using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05_collection_event
{
    //1. dinh nghia delegate [MyDelegate] ham void co 1 tham so kieu string.
    public delegate void MyDelegate(string s);
    class StudentEvent
    {
        //2. dinh nghia 1 event, kich hoat khi du lieu cua property khong hop le
        public event MyDelegate invalidData;
        private string id, name;
        private int mark;
        //3. ham xu ly su kien co cung prototype voi delegate
        public void Minh(string s)
        {
            throw new FormatException(s);
        }

        //4. dang ky cho ham MInh xu y su kien invalidData
        public StudentEvent()
        {
            invalidData = new MyDelegate(Minh);
        }
        //>>>>>>property cho id
        public string pID
        {
            get { return id; }
            set
            {
                if (Regex.IsMatch(value, "^SV\\d{3}$"))
                {
                    id = value;
                }
                else
                {
                    invalidData("ID khong hop le!!! [SVxxx voi x la ky so]");
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
                if (value.Trim().Length >= 2)
                {
                    name = value;
                }
                else
                {
                    invalidData("Ten khong hop le!! ten phai co it nhat 2 ky tu");
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
                    invalidData("Diem khong hop le!! [0-100]");
                }
            }
        }
        //ket thuc property cho mark<<<<<<<<

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", id, name, mark);
        }
    }
}
