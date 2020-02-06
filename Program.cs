using System;

namespace Supportbank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Transaction myTransaction = new Transaction();
            
            FileReader fileReader = new FileReader();
            var transactionsString = fileReader.ReadDataFile();

        }
    }
}