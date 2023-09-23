using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;

namespace RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //As a MOBA challenger player, Petar has the bad habit of trashing his PC when
            //he loses a game and of rage quiting. His gaming setup consists of a headset, mouse, keyboard, and display.
            //You will receive Petar's lost games count. 
            //Every 2 lost game, Petar trashes his headset.
            //Every 3 lost game, Petar trashes his mouse.
            //When Petar trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
            //Every 2 time, when he trashes his keyboard, he also trashes his display.
            //You will receive the price of each item in his gaming setup.
            //Calculate his rage expenses for renewing his gaming equipment.
            //Input / Constraints
            //•	On the first input line – lost games count – integer in the range[0…1000].
            //•	On the second line – headset price – floating - point number in the range[0…1000].
            //•	On the third line – mouse price – floating - point number in the range[0…1000].
            //•	On the fourth line – keyborad price – floating - point number in the range[0…1000].
            //•	On the fifth line – display price – floating - point number in the range[0… 1000].
            //Output
            //•	As output you must print Petar's total expenses: "Rage expenses: {expenses} lv.".
            //•	Allowed working time / memory: 100ms / 16MB.
            int lostGame = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboradPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headset = (lostGame / 2) * headsetPrice;
            double mouse = (lostGame / 3) * mousePrice;
            double keyboard = (lostGame / 6) * keyboradPrice;
            double display = (lostGame / 12) * displayPrice;
            double expenses = headset + mouse + keyboard + display;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");



        }
    }
}
