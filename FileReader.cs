using System;
using System.Collections.Generic;
using System.IO;

namespace Supportbank
{
    public class FileReader
    {
        public string ReadDataFile()
        {
            var transactionLines = File.ReadAllLines("Transactions.csv");
            return transactionLines.ToString();
        }
    }
}