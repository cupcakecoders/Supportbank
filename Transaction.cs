using System;
using System.Collections.Generic;

namespace Supportbank
{
    public class Transaction
    {
        //properties 
        private DateTime TransactionDates { get; }
        private string FromUser { get; }
        private string ToUser { get; }
        private string TransactionDescription { get; }
        private double TransactionAmount { get; }
        
        // construction. i can make a constructor that does not have parameters that way the new instance will not ask for it.
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