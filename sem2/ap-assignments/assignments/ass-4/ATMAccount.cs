using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Banking
{
    class ATMAccount
    {
        private string accNo;
        private int balance;

        public string pAccNo
        {
            get { return accNo; }
            set
            {
                if (Regex.IsMatch(value, "^ACC-\\d{5}$"))
                {
                    accNo = value;
                }
                else
                {
                    throw new Exception("Account number format is wrong [ACC-xxxxx] x is decimal");
                }
            }
        }

        public int pDeposit
        {
            set
            {
                if (value >= 100)
                {
                    balance += value;
                }
                else
                {
                    throw new Exception("The amount must be >= 100");
                }
            }
        }

        public int pWithdraw
        {
            set
            {
                if(value>= 100 && value < balance)
                {
                    balance -= value;
                }
                else
                {
                    throw new Exception("The amount must be >= 100 and < balance");
                }
            }
        }

        public int pBalance
        {
            get { return balance; }
        }

        public void input()
        {
            while (true)
            {
                try 
                { 
                    Console.Write("Input acc number: ");
                    pAccNo = Console.ReadLine().Trim();
                    break;
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }

            }
            while (true)
            {
                try
                {
                    Console.Write("Deposit amount[>=100]: ");
                    pDeposit = int.Parse(Console.ReadLine().Trim());
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
            return string.Format("accNo: {0},balance: {1}", pAccNo,pBalance);
        }

        public ATMAccount()
        {
            input();
        }

    }
}
