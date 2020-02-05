using System;
using System.IO;

namespace Supportbank
{
    public class Readfile
    {
        public static string ReadDataFile()
        {
            var rawData = File.ReadAllText("Transactions.csv");
            return rawData;
        }
    }
}