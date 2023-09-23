using System;

namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You will be given an integer, write a program which checks if the given integer is divisible by 2 or 3,
            // or 6, or 7, or 10 without a remainder.You should always take the bigger division:

            //•	If the number is divisible by both 2, 3, and 6, you should print the division by 6 only.
            //•	If a number is divisible by 2 and 10, you should print the division by 10.

            //If the number is not divisible by any of the given numbers, print "Not divisible".
            //Otherwise, print "The number is divisible by {number}".

            int num = int.Parse(Console.ReadLine());
            int n2 = 2;
            int n3 = 3;
            int n6 = 6;
            int n7 = 7;
            int n10 = 10;
            if (num % n10 == 0) { Console.WriteLine($"The number is divisible by {n10}"); }
            else if (num % n7 == 0) { Console.WriteLine($"The number is divisible by {n7}"); }
            else if (num % n6 == 0) { Console.WriteLine($"The number is divisible by {n6}"); }
            else if (num % n3 == 0) { Console.WriteLine($"The number is divisible by {n3}"); }
            else if (num % n2 == 0) { Console.WriteLine($"The number is divisible by {n2}"); }
            else { Console.WriteLine("Not divisible"); }
        }
    }
}
