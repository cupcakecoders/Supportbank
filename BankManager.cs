using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Supportbank
{
    public class BankManager
    {
        public List<Account> CreateUser(List<Transaction> transactions) //we are returning an instance of class Account which will be a list. We are passing in a transactions list. at this stage we dont need to know which specific list this is we only pass it in. We specify which list in the program.cs file in the is case its transactionsList made in FileReader class.
        {
            List<Account> userAccounts = new List<Account>(); //new instance of class account
            
            foreach (var transaction in transactions)
            {
                if (!DoesUserExist(userAccounts, transaction.ToUser))
                {
                    Account userAccount = new Account(transaction.ToUser);// add a new account to the list.
                    userAccounts.Add(userAccount);
                }
            }
            return userAccounts;
        }

        private bool DoesUserExist(List<Account> accounts, string accountholder)
        {
            foreach (var account in accounts)
            {
                if (account.AccountName.Equals(accountholder))
                {
                    return true;
                }
            }
            return false;
        }

        public void AddTransactionsToAccount(List<Account> userAccounts, List<Transaction> transactions)
        {
            //end up with a list for each user with transaction with their name in ToUser or FromUser.
            //nested loop which loops through each account, then loops through each transaction to find those where AccountName(string) == transaction.ToUser 
            //alternatively update account balance based on transactions + or - depending on if owed or owing

            //var all = transactions.Where(t => userAccounts.Any(a => a.AccountName == t.ToUser));
            
            foreach (var account in userAccounts)
            {
                string userAccountName = account.AccountName;
                foreach (var transaction in transactions)
                {
                    if (transaction.FromUser.Equals(userAccountName))
                    {
                        account.UserFromTransactions.Add(transaction);
                    }
                }
            }
            //add transaction ToUser
        }
    }
}