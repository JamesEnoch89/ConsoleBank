using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMmachine
{
    class Account
    {
        public decimal Balance { get; set; }
        public decimal Interest { get; set; }
        //private decimal balance = 0;
        private decimal interest;

        public void Deposit(decimal amount)
        {
            Balance = Balance + amount;
        }

        public bool Withdraw(decimal amount) //balance has to be >= 0 after withdraw
        {
            if (amount > Balance)
            {
                return false; //insufficient funds
            }
            Balance = Balance - amount;
            return true; //enough funds
        }

    }
}

