using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace Supportbank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Transaction myTransaction = new Transaction();
            FileReader fileReader = new FileReader();
            var transactionsList = fileReader.ReadDataFile();
            
            Console.WriteLine("Which user do you want to see transactions for?");
            var user = Console.ReadLine();
                
            var groupedUserList = transactionsList
                //.GroupBy(u => u.FromUser)
                .Where(t => t.FromUser == user);
                //.Select(grp => grp.ToList());
                
                var groupedCustomerList = transactionsList
                    .GroupBy(u => u.ToUser);
                //.Select(grp => grp.ToList());
            
            foreach (var t in groupedUserList)
            {
                    Console.WriteLine($"{t.FromUser} to {t.ToUser} for {t.TransactionDescription} on {t.TransactionDates}");
            }
            
            
            

            
            
            
            
            
            
            //transactionsList = make an instance of an account for each person
            // sum up amount each person owes other person
            // print out names and figures

        }
    }
}