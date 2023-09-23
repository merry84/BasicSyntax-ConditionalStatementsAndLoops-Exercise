using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You will receive three lines from the console:
            //•	A count of people who are going on vacation.
            //•	Type of the group(Students, Business or Regular).
            //•	The day of the week which the group will stay on(Friday, Saturday or Sunday).
            //Based on the given information calculate how much the group will pay for the entire vacation.

            //The price for a single person is as follows:
            //	          Friday  Saturday    Sunday
            //Students    8.45    9.80    10.46
            //Business    10.90   15.60   16
            //Regular     15      20      22.50

            //There are also discounts based on some conditions:
            //•	For Students – if the group is 30 or more people, you should reduce the total price by 15 %.
            //•	For Business – if the group is 100 or more people, 10 of the people stay for free.
            //•	For Regular – if the group is between 10 and 20  people(both inclusively),
            //reduce the total price by 5 %.

            //Note: You should reduce the prices in that EXACT order!

            //As an output print the final price which the group is going to pay in the format: 
            //"Total price: {price}"
            //The price should be formatted to the second decimal point
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayofWeek = Console.ReadLine();
            double studentPrice = 0;
            double businessPrice = 0;
            double regularPrice = 0;
            double totalPrice = 0;

            if (typeOfGroup == "Students")
            {
                if (dayofWeek == "Friday")
                {
                    studentPrice = 8.45;
                }
                else if (dayofWeek == "Saturday")
                {
                    studentPrice = 9.80;
                }
                else if (dayofWeek == "Sunday") { studentPrice = 10.46; }
                totalPrice = studentPrice * countOfPeople;
                if (countOfPeople >= 30 && typeOfGroup == "Students") { totalPrice *= 0.85; }
            }
            else if (typeOfGroup == "Business")
            {
                if (dayofWeek == "Friday") { businessPrice = 10.90; }
                else if (dayofWeek == "Saturday") { businessPrice = 15.60; }
                else if (dayofWeek == "Sunday") { businessPrice = 16; }
                totalPrice = businessPrice * countOfPeople;
                if (countOfPeople >= 100 && typeOfGroup == "Business") { totalPrice = (countOfPeople - 10) * businessPrice; }

            }
            else if (typeOfGroup == "Regular")
            {
                if (dayofWeek == "Friday") { regularPrice = 15; }
                else if (dayofWeek == "Saturday") { regularPrice = 20; }
                else if (dayofWeek == "Sunday") { regularPrice = 22.50; }
                totalPrice = regularPrice * countOfPeople;
                if (countOfPeople > 10 && countOfPeople < 20) { totalPrice *= 0.95; }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
