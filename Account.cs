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
        public List<Transaction> UserFromTransactions = new List<Transaction>();
        public List<Transaction> UserToTransactions = new List<Transaction>();

        //constructor
        public Account(string accountName)
        {
            this.AccountName = accountName;
        }

        public Account()
        {
            
        }

        // method to show fromuser and touser transactions
        public List<Transaction> CombinedFromToTransactions()
        {
            return UserFromTransactions.Concat(UserToTransactions).ToList();
        }
        
        // method to add up all the transactions where the to user is the same for account holder
        public double AmountUserOwes()
        {
            double accountBalanceOwes = 0;
            
            foreach (var transaction in UserFromTransactions)
            {
                accountBalanceOwes += transaction.TransactionAmount;
            }
            return accountBalanceOwes;
        }
        public double AmountUserOwed()
        {
            double accountBalanceOwed = 0;
            
            foreach (var transaction in UserToTransactions)
            {
                accountBalanceOwed += transaction.TransactionAmount;
            }
            return accountBalanceOwed;
        }
    }
}
    
