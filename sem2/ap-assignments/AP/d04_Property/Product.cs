using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace d04_Property
{
    public class Product
    {
        string id,name;
        int price;

        //dinh nghia property pID thm chieu field id
        public string pID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;// gan noi dung cua property cho bien tham chieu id
            }
        }

        //dinh nghia property pName tham chieu field name
        public string pName
        {
            get
            {
                return name;
            }
            set
            {
                if(Regex.IsMatch(value,"^[a-z 0-9A-Z]{3,20}$"))
                {
                    name = value;// gan noi dung cua property cho bien tham chieu name
                }
                else
                {
                    throw new FormatException("Ten san pham khong hop le");
                }
            }
        }

        public int pPrice
        {
            get
            {
                return price;
            }
            set
            {
                if(value>0 && value < 1000)
                {
                    price = value;

                }
                else
                {
                    throw new FormatException("Don gia khong hop le");
                }

            }
        }
    }
}
