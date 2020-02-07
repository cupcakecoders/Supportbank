using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Supportbank
{
    public class Account
    {   
        //this class should create an account for each unique person owed. initialise it with account name and empty strings and 0 in amount.

        public string AccountName;
        public List<Transaction> AccountTransactions;

        //constructor
        public Account(string accountName)
        {
            this.AccountName = accountName;
        }
        

    }

}
    
