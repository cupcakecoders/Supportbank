using System.Collections.Generic;

namespace Supportbank
{
    public class TransactionManager
    {
        
        // iterate through transactionLines split on comma to get each line, then split again to get each item in each line

        /*public string ExtractEachLine(string transactions)
        {
            
            
            //return string oneTransaction;
        }
        */
        
        /*//put this in a different class to this one
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
        }*/
    }
}