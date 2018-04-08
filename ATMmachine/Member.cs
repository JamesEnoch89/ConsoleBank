using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMmachine

    // Account Member and Log-In Credentials
{
    class Member
    {
        public string Name { get; set; }
        public string PIN { get; set; }
        public Account Checking { get; set; }
        public Account Savings { get; set; }

        public Member(string name, string pin, Account checking, Account savings)
        {
            Name = name;
            PIN = pin;
            Checking = checking;
            Savings = savings;
        }

        public Member(string activeName, string activePin)
        {
        }

    }
}
