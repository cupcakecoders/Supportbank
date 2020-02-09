using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Supportbank
{
    public static class FileReader
    {
        public static List<Transaction> ReadDataFile()
        {
            List<Transaction> transactionsList = new List<Transaction>(); 
            
            IEnumerable<string> transactionLines = File.ReadAllLines("Transactions.csv");

            foreach (var line in transactionLines.Skip(1))
            {
                var words = line.Split(",");

                string transactiondates = words[0];
                var from = words[1];
                var to = words[2];
                var description = words[3];
                var amount = Double.Parse(words[4]);
                
                Transaction eachTransaction = new Transaction(transactiondates, from, to, description, amount);
                    
                transactionsList.Add(eachTransaction);
            }
            return transactionsList;
        }
    }
}