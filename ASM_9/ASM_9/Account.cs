using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_9
{
    public class Account
    {
        private int mCode;

        public int code
        {
            get { return mCode; }
            set { mCode = value; }
        }

        private string mName;

        public string name
        {
            get { return mName; }
            set { mName = value; }
        }
        private int mBalance;

        public int balance
        {
            get { return mBalance; }
            set { mBalance = value; }
        }

        public Account()
        {
        }

        public int GetCash
        {
            set
            {
                if (value > mBalance)
                {
                    Console.WriteLine("The Value cannot be greater than the current balance");
                } else
                {
                    mBalance -= value;
                    Console.WriteLine("Success withdraw "+value+" by cash");
                }
            }
        }

        public int DepositeCash
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("The amount must be greater zeros");
                } else
                {
                    mBalance += value;
                    Console.WriteLine("Successfull depositation"+value+" by cash");
                }
            }
        }

        public int DepositeCheck
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("The amount must be greater than zeros");
                } else
                {
                    mBalance += value;
                    Console.WriteLine("Successfull deposite " + value + " by check");
                }
            }
        }

        public int BalanceStatement
        {
            get
            {
                return balance;
            }
        }
        
        public int Tranfer
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("The amount must be greater than zeros");
                } else if (value > mBalance)
                {
                    Console.WriteLine("Your accounr is insufficient");
                } else
                {
                    mBalance -= value;
                    //Console.WriteLine("Successfull tranfer " + value + " ");
                    Console.WriteLine($"Successfull tranfer {value} to receiver");
                }
            }
        }
    }
}
