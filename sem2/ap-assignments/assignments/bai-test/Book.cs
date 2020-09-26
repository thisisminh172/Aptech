using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace bai_test
{
    public class Book : Library
    {
        private string title;
        private double price;
        private bool isSale;

        public string pTitle
        {
            get { return title; }
            set
            {
                if(Regex.IsMatch(value,"^[a-z A-Z0-9]{1,}$"))
                {
                    title = value;
                }
                else
                {
                    throw new FormatException("character and digits only");
                }
            }
        }
        public double pPrice
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    throw new Exception("Must be greater than 0");
                }
            }
        }

        public bool pIsSale
        {
            get { return isSale; }
            set
            {
                isSale = value;
            }
        }
        public override void bookInfo()
        {
            Console.WriteLine(">>> Book info <<<");
            Console.WriteLine($"Book title: {title}");
            Console.WriteLine($"Book price: {price}");
            Console.WriteLine($"Book sale: {isSale}");
        }
        public override string ToString()
        {
            return string.Format($"title: {title}, price: {price}, isSale: {isSale}");
        }
    }
}
