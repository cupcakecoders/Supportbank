using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Supportbank
{
    public class Account
    {   
        //this class creates an account for each person owed. initialise it with account name and empty strings and 0 in amount.
        public string AccountName;
        public double AccountBalance;
        public List<Transaction> UserFromTransactions = new List<Transaction>();
        public List<Transaction> UserToTransactions = new List<Transaction>();

        //constructor
        public Account(string accountName)
        {
            this.AccountName = accountName;
        }

        //overloading with another constructor
        public Account(string accountName, double accountBalance)
        {
            this.AccountName = accountName;
            this.AccountBalance = accountBalance;
        }
        // method to show fromuser and touser transactions
        public List<Transaction> CombinedFromToTransactions()
        {
            return UserFromTransactions.Concat(UserToTransactions) as List<Transaction>;
        }
        
        // method to add up all the transactions where the touser is the same for account holder
        

        //method to add up all the transactions where the fromuser is the same for account holder
    }
}
    
