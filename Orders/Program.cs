using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //We are placing N orders at a time. You need to calculate the price with the following formula:
                //((daysInMonth * capsulesCount) * pricePerCapsule)

                //Input / Constraints
                //•	On the first line, you will receive integer N – the count of orders the shop will receive.
                //•	For each order you will receive the following information:
                //   o Price per capsule – floating - point number in the range[0.00…1000.00].
                //   o Days – integer in the range[1…31].
                //   o Capsules count – integer in the range[0…2000].
                //The input will be in the described format, there is no need to check it explicitly.
                //Output
                //The output should consist of N + 1 line.For each order you must print a single line in the following format:
                //•	"The price for the coffee is: ${price}"
                //On the last line, you need to print the total price in the following format:
                //•	 "Total: ${totalPrice}"
                //The price must be formatted to 2 decimal places. 
            int countOfOrders = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            double price = 0;

            for (int i = 1; i <= countOfOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                price =((days * capsulesCount) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totalPrice += price;
            }
            
            Console.WriteLine($"Total: ${totalPrice:f2}");
            

        }
    }
}
