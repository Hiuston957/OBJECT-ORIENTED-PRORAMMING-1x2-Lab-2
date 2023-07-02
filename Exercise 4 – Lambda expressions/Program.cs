/* Lambda expressions are anonymous functions of the form: parameter => expression.
We’ve met them when using collections – let’s try it again.  */

using System;
using System.Collections.Generic;
using System.Linq;
namespace Ex_02_04
{

    class Program
    {
        static void Main(string[] args)
        {
            // Enumerable.Range(x, n) -> n integers, from x to (x+n-1)
            // Enumerable.Repeat(x, n) -> n values, all equal x
            List<int> numbers = Enumerable.Range(0, 30).ToList(); // 0-29
                                                                  // Take only even elements
            var even = numbers.FindAll(x => x % 2 == 0);
            PrintList(even);
            // Take square of each element
            var squared = numbers.Select(x => x * x).ToList();
            PrintList(squared);
            // Remove all elements between 10 and 20
            numbers.RemoveAll(x => x > 10 && x < 20);
            PrintList(numbers);
            // Order elements
            var beverly = new List<int> { 9, 0, 2, 1, 0 };
            var ordered = beverly.OrderBy(v => v).ToList();
            PrintList(ordered);

            List<int> tab = new List<int> { 1, 10, 20, 30, 40, 50 };
            var xdtab = tab.Select(x => x + 5).ToList();


            PrintList(tab);
            PrintList(xdtab);
        }
        /**********************************************************************/
        static void PrintList(List<int> list)
        {
            list.ForEach(y => Console.Write(y + " "));
            Console.WriteLine();
        }
    }
}


