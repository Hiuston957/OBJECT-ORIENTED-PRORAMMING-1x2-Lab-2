/*LINQ (Language INtegrated Query) is a built-in query syntax for C# to retrieve data from
various sources and formats. For example, we can use it to work with collections.
 */

using System;
using System.Collections.Generic;
using System.Linq;
namespace Ex_02_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 50, 13, 11, 3, 24, 9, 49 };
            var animals = new List<string>() { "cat", "horse", "tiger", "mouse" };
            // Get numbers in order
            var ordered = from x in numbers
                          orderby x ascending
                          select x;
            // Select only even numbers and divide them by 2
            var divided = from x in numbers
                          where x % 2 == 0
                          select x / 2;
            // Choose only animals with 'o'
            var onimols = from s in animals
                          where s.Contains('o')
                          select s;
            // Choose only animals with 5 letters and get them in a descending order
            var fives = from s in animals
                        where s.Length == 5
                        orderby s descending
                        select s;
            // Printing
            ordered.ToList().ForEach(n => Console.WriteLine(n));
            Console.WriteLine();
            divided.ToList().ForEach(n => Console.WriteLine(n));
            Console.WriteLine();
            onimols.ToList().ForEach(n => Console.WriteLine(n));
            Console.WriteLine();
            fives.ToList().ForEach(n => Console.WriteLine(n));
            Console.WriteLine();
        }
    }
}
