using System;

namespace Supportbank
{
    class Program
    {
        static void Main(string[] args)
        {
            var readfile = Readfile.ReadDataFile();
            Console.WriteLine(readfile);
        }
    }
}