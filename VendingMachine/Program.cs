using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Write a program that accumulates coins. Until the "Start" command is given,
            //  you will receive coins, and only the valid ones should be accumulated.Valid coins are:
            //•	0.1, 0.2, 0.5, 1 and 2
            //If an invalid coin is inserted, print "Cannot accept {money}" and continue to the next line.
            //On the next lines, until the "End" command is given, you will start receiving products,
            //which a customer wants to buy. The vending machine has only:

            //•	"Nuts" with a price of 2.0
            //•	"Water" with a price of 0.7
            //•	"Crisps" with a price of 1.5
            //•	"Soda" with a price of 0.8
            //•	"Coke" with a price of 1.0

            //If the customer tries to purchase a not existing product, print "Invalid product".

            //When a customer has enough money to buy the selected product,
            //print "Purchased {product name}", otherwise print "Sorry, not enough money"
            //and continue to the next line.
            //When the "End" command is given print the reminding balance,
            //formatted to the second decimal point: "Change: {money left}".

            string input = Console.ReadLine();
            double sumCoins = 0;
            while (input != "Start")
            {
                double coins = double.Parse(input);
                

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sumCoins += coins;
                    

                }
                else { Console.WriteLine($"Cannot accept {coins}"); }
               
                input = Console.ReadLine();
            }


            string product = Console.ReadLine();

            while (product != "End")
            {
               
                if (product == "Nuts")
                {
                    if (sumCoins >= 2.00)
                    {
                        sumCoins -= 2.00;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else { Console.WriteLine("Sorry, not enough money"); }

                }
                else if (product == "Water")
                {
                    if (sumCoins >= 0.70)
                    {
                        sumCoins -= 0.70;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else { Console.WriteLine("Sorry, not enough money"); }

                }
                else if (product == "Crisps")
                {
                    if (sumCoins >= 1.50)
                    {
                        sumCoins -= 1.50;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else { Console.WriteLine("Sorry, not enough money"); }

                }
                else if (product == "Soda")
                {
                    if (sumCoins >= 0.80)
                    {
                        sumCoins -= 0.80;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else { Console.WriteLine("Sorry, not enough money"); }

                }
                else if (product == "Coke")
                {
                    if (sumCoins >= 1.00)
                    {
                        sumCoins -= 1.00;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else { Console.WriteLine("Sorry, not enough money"); }

                }
                else { Console.WriteLine("Invalid product"); }

                product = Console.ReadLine();

            }

            Console.WriteLine($"Change: {sumCoins:f2}");

        }
    }
}
