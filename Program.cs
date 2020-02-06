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

            var groupedUserList = transactionsList
                .GroupBy(u => u.FromUser)
                .Select(grp => grp.ToList());
            
            foreach (var group in groupedUserList)
            {
                Console.WriteLine(group.Count());
            }
            

            
            
            
            
            
            
            //transactionsList = make an instance of an account for each person
            // sum up amount each person owes other person
            // print out names and figures

        }
    }
}