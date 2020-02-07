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
            List<Account> userAccounts = new List<Account>();
            
            foreach (var transaction in transactions )
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
      
    }
}