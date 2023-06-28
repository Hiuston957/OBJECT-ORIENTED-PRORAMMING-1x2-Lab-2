/*A delegate is a reference type that can hold a reference to a method.Think of it as a box,
inside which you put a method. When you run the delegate, the method inside is called.
We can also reference (add) many methods within a single delegate. When you run such a
delegate, all its methods will be run, in the same order as they were added.However, only
the last method in the delegate will provide the return result.
*/

using System;
namespace Ex_02_07
{
    class Program
    {
        // Declaration of a delegate which takes two ints and returns int
        // You can set this delegate to any method that takes two ints and returns int
        delegate int MathOperation(int a, int b);
        static void Main(string[] args)
        {
            // Create delegate instance
            MathOperation del = Method1; // or = new MathOperation(Method1)
            del(1, 2); // or del.Invoke(1, 2);
                       // Set to another method
            del = Method2;
            del(8, 5);
            // Set to a lambda expression
            del = (x, y) => x - y;
            int result = del(10, 15);
            Console.WriteLine(result);
            /**************************************************/
            // Multicast delegate
            del = Method1; // set 1st method
            del += Method1; // add 1st method again
            del += Method2; // add 2nd method
                            // del -= Method1;
            Console.WriteLine("----------------");
            // Run the multicast delegate and check its return output
            result = del(5, 10);
            Console.WriteLine("Multicast output: " + result);
        }
        /******************************************************************/
        static int Method1(int x, int y)
        {
            int z = x + y;
            Console.WriteLine(z);
            return z;
        }
        static int Method2(int x, int y)
        {
            int z = x * y;
            Console.WriteLine(z);
            return z;
        }
    }
}