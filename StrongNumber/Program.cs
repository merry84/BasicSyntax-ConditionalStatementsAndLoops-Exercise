using System;

namespace StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that receives a single integer and calculates if it's strong or not.
            // A number is strong, if the sum of the factorials of each digit is equal to the number itself.

            //Example: 145 is a strong number, because 1! + 4! + 5! = 145.
            //Print "yes", if the number is strong and "no", if the number is not strong.


            string num = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int factorial = 1;
                int currentNum = int.Parse(num[i].ToString());

                for (int j = 1; j <= currentNum; j++)
                {
                    factorial *= j;
                }
                sum += factorial;
            }
            if (sum == int.Parse(num))
            {
                Console.WriteLine("yes");
            }
            else { Console.WriteLine("no"); }

        }
    }
}
