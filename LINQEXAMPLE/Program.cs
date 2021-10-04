using System;
using System.Linq;

namespace LINQEXAMPLE
{
    class Program
    {
        static void Main(string[] args)
        {
            //our data source
            string[] names = { "Billy", "John", "Steve", "Brown" };
            //linq query
            var myLinqResult = from name in names where name.Contains('B') select name;
            //execute query
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("we are strating to show linq result: ...");
            foreach (var name in myLinqResult)
                Console.WriteLine(name);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
        }
    }
}
