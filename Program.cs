using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace Supportbank
{
    class Program
    {
        static void Main(string[] args)
        {
            var transactionsList = FileReader.ReadDataFile();
            var bankManager = new BankManager(); //in bank manger we have a createuser method. this is a new instance of that class. so we can then access the method below.
            var userAccounts = bankManager.CreateUser(transactionsList); //accesses create user method on new instance of bank manager class. passes in specific list of data in form of variable. class.
            bankManager.AddTransactionsToAccount(userAccounts, transactionsList);
            /*Console.WriteLine("Which user's transactions would you like to see? Jon A, Stephen S, Laura B, Rob S, Sam N, Todd, Chris W, Dan W, Tim L, Ben B, Sarah T, Gergana I");
            var user = Console.ReadLine();
            var accountQueried = userAccounts.Find(u => u.AccountName == user);
            Console.WriteLine(accountQueried.UserFromTransactions);*/
            Console.WriteLine("Choose List All or List <Account>");
            var response = Console.ReadLine();
            if (response == "List All")
            {
                foreach (var account in userAccounts)
                {
                    Console.WriteLine($"{account.AccountName} owes {account.AmountUserOwes()} and is owed {account.AmountUserOwed()}");
                    
                }
            }

            if (response == "List Jon A")
            {
                var accountName = "Jon A";

                foreach (var account in userAccounts)
                {
                    if (accountName == account.AccountName)
                    {
                        foreach (var transaction in account.CombinedFromToTransactions())
                        {
                            Console.WriteLine(transaction);
                        }
                    }
                }
            }
        }
    }
}