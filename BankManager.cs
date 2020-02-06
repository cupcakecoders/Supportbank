using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Supportbank
{
    public class BankManager
    {
       // Go through list of data and find unique toUser. If an account for them does not exist then create account.
       //Go through list and put each line in while toUser appears in either toUser or fromUser
       //public List<Transaction> GroupByUser(List<Transaction> transactions)
       


       // This will return a list of all Stock objects having the specified Type
        //static List<Stock> GetItemsForType(string type)
        /*public List<Account> accounts = new List<Account>();
        {
            return System.Transactions.Transaction
                .Where(item => item.Type == type)
                .ToList();
        }*/

// This will return a list of the names of all Type values (no duplicates)
        /*static List<string> GetStockTypes()
        {
            return stock
                .Select(item => item.Type)
                .Distinct()
                .ToList();
        }
        */
        
        
        
        
        // private list of accounts
        
        //takes transactionsList create
        // createAccounts(list of transactions)
        //   --> checkIfAccountMade(fromuser or the touser)
        //   --> new Account(....) - saves to list 
        
        
        // private checkIfACcountMade(user)
        // ---> accounts.foreach acc 
        // if acc.firstName === user.firstname then account already made return true 
    }
}