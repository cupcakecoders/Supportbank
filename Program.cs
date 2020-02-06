using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Supportbank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Transaction myTransaction = new Transaction();
            
            FileReader fileReader = new FileReader();
            var transactionsList = fileReader.ReadDataFile();

            List<Account> accounts = new List<Account>();
            foreach (var transaction in transactionsList)
            {
                if (accounts.Contains(new Account())
                {
                    var accountHolder = transaction.FromUser;
                    var userAccount = new Account(accountHolder);
                    accounts.Add(userAccount);
                }
            }
            //transactionsList = make an instance of an account for each person
            // sum up amount each person owes other person
            // print out names and figures

        }
    }
}