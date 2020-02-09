using System;
using System.Collections.Generic;

namespace Supportbank
{
    public class Transaction
    {
        //properties 
        public DateTime TransactionDates { get; }
        public string FromUser { get; }
        public string ToUser { get; }
        public string TransactionDescription { get; }
        public double TransactionAmount { get; }
        
        // constructor. i can make a constructor that does not have parameters that way the new instance will not ask for it.
        public Transaction(DateTime transactionDates, string fromUser, string toUser, string transactionDescription, double transactionAmount)
        {
            this.TransactionDates = transactionDates;
            this.FromUser = fromUser;
            this.ToUser = toUser;
            this.TransactionDescription = transactionDescription;
            this.TransactionAmount = transactionAmount;
        }

    }
}