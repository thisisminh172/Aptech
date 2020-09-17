using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05_event_delegate
{
    //dn delegate co prototype cho ham muon xu ly event
    public delegate void DeleMess(string s);
    class DemoEvent
    {
        event DeleMess sample;
        public void demo()
        {
            //dang ky xu ly su kien sample
            sample = new DeleMess(showMessage);
            Console.WriteLine("Nhap vao 1 so nguyen duong: ");
            int n = int.Parse(Console.ReadLine().Trim());
            if (n < 0)
            {
                sample("Bao la nhap so duong ma!!!");
            }
            //Console.WriteLine("Ket thuc demo");
            sample("ket thuc demo");
        }

        //ham in chuoi tham so message
        public void showMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
