using System;
using System.Collections.Generic;

namespace Supportbank
{
    public class Transaction
    {
        //properties 
        private DateTime TransactionDates { get; set; }
        private string FromUser { get; set; }
        private string ToUser { get; set; }
        private string TransactionDescription { get; set; }
        private int TransactionAmount { get; set; }
        
        // construction. i can make a constructor that does not have parameters that way the new instance will not ask for it.
        public Transaction(DateTime transactionDates, string fromUser, string toUser, string transactionDescription, int transactionAmount)
        {
            this.TransactionDates = transactionDates;
            this.FromUser = fromUser;
            this.ToUser = toUser;
            this.TransactionDescription = transactionDescription;
            this.TransactionAmount = transactionAmount;
        }

        //put this in a different class to this one
        public List<Transaction> ListOfTransactions()
        {
            List<Transaction> transList = new List<Transaction>();
            
            foreach (var transaction in FileReader.ReadDataFile()) //Think I need to create a new instance of FileReader to then use here.
            {
                transList.Add(item: new Transaction(TransactionDates, FromUser, ToUser, TransactionDescription, TransactionAmount));
                return transList;
            }
            
            foreach (var transaction in transList)
            {
                Console.WriteLine(transaction);
            }
            return null;
        }
    }
}