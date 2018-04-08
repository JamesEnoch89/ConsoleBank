using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 On Load Program Display: Checking Balance:     Savings Balance:   

Program Display: Choose Checking or Savings? 

Classes:

    Checking: What does it take to create a checking account?
        Name
        Pin or Acct Num
        Balance (Starting Balance) csv 

    Savings: What does it take to create a savings account?
        Name
            Store name from prompt?
        Pin or Acct Num
            Store pin from prompt
        Balance (Potential for growth) 
        Question: Wouldn't it make more sense to instantiate a user first
            to more easily transer between accounts? Or would you just call a constructor?

    Program Display For Both Checking and Savings:
        Withdraw:
            Enter amount
            => Deduct amount from total balance and update
                must be int, balance >= withdraw amount

                constructor?
        Deposit:
            Enter amount
            => Add amount to current balance and update balance
                must be int
        Transfer:
            Display amounts in both accounts
            Select account to deduct from
            Deduct amount from selected accout
            Add amount to other account
            => 

    Total transactions: Streamfile?
    */

namespace ATMmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberDirectory = new Dictionary<string, string>();
            const string USER_PATH = "../../memberDirectory.csv";
            using (var reader = new StreamReader(USER_PATH))
            {
                while (reader.Peek() > -1)
                {
                    var line = reader.ReadLine().Split(',');
                    if (!memberDirectory.ContainsKey(line[0]))
                    {
                        memberDirectory.Add(line[0], line[1]);
                    }

                }
                foreach (var registered in memberDirectory)
                {
                    Console.WriteLine($"{registered.Key} Is In The System");
                }
            }
            Console.WriteLine("Welcome To The Console Banking System");
            Console.WriteLine("Would you like to (view) or (create) an account?");
            string memberInput = Console.ReadLine().ToLower();

            if (memberInput == "view")
            {
                // prompt for log in credentials to view
                Console.WriteLine("To view your account please enter your login information");
                Console.WriteLine("Please enter your name to login:");
                var activeName = Console.ReadLine().ToLower();

                Console.WriteLine("Please enter your PIN code");
                var activePin = Console.ReadLine();

                var activeMember = new Member(activeName, activePin);
                Console.WriteLine($"Thanks {activeMember.Name}. You are now logged in");
                //Console.WriteLine($" Your checkings account balance is: {activeMember.Checking.Balance}");

                Console.WriteLine("Would you like to view your (checking) or (savings) account?");
                string memberAccountResponse = Console.ReadLine().ToLower();

                if (memberAccountResponse == "checking")
                {

                    Console.WriteLine($"Would you like to (withdraw), make a (deposit), make a (transfer) or (exit)?");
                    string memberOptionsResponse = Console.ReadLine().ToLower();

                    if (memberOptionsResponse == "deposit")
                    {
                        // run deposit function from account class somehow
                        // give the user a log of recent transaction
                        Console.WriteLine("You've deposited ??? your new balance is ???");
                    }
                    else if (memberOptionsResponse == "withdraw")
                    {
                        // run withdraw function from account class somehow
                        // give the user a log of recent transaction
                        Console.WriteLine("You've withdrawn ??? your new balance is ???");
                    }
                    else if (memberOptionsResponse == "transfer")
                    {
                        // create a transfer function
                        // give the user a log of recent transaction
                        Console.WriteLine("You've transferred ??? to your savings account. Your new balance is ???");
                    }

                    else if (memberOptionsResponse == "exit")
                    {
                        // create an is logged in, set to false ??

                    }

                }
                else if (memberInput == "create")
                {
                    // prompt for creation credentials
                    Console.WriteLine("To create an account please enter a name:");
                    // save members name
                    var memberName = Console.ReadLine().ToLower();

                    Console.WriteLine("To finish creating an account please enter a PIN:");
                    // save members PIN
                    var memberPin = Console.ReadLine().ToLower();

                    var newMember = new Member(memberName, memberPin);
                    Console.WriteLine($"Thanks {newMember.Name}. You've created a new account");

                    using (var writer = new StreamWriter(USER_PATH))
                    {
                        memberDirectory.Add(newMember.Name, newMember.PIN);
                        foreach (var Member in memberDirectory)
                        {
                            writer.WriteLine($"{Member.Key},{Member.Value}");
                        }
                    }

                    //validate user is logged in?
                    // when logged in display account balances






                }

            }
        }
    }
