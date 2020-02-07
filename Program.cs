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
            //Transaction myTransaction = new Transaction();
            //FileReader fileReader = new FileReader();
            //var transactionsList = fileReader.ReadDataFile();
            var transactionsList = FileReader.ReadDataFile();
            var bankManager = new BankManager(); //in bank manger we have a createuser method. this is a new instance of that class. so we can then access the method below.
            var userAccounts = bankManager.CreateUser(transactionsList); //accesses create user method on new instance of bank manager class. passes in specific list of data in form of variable. class.
            //Console.WriteLine(accounts);
            var accountswithtransactions = bankManager.AddTransactionsToAccount(userAccounts, transactionsList);
        }
    }
}