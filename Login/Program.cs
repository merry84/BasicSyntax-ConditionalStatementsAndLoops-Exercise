using System;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // On the first line, you will be given a username and your task is to try to log in the user.
            // The user's password is the username reversed. On the next lines, you will receive passwords:
            //   •	If the password is incorrect, print "Incorrect password. Try again.".
            //   •	If the password is correct, print "User {username} logged in." and stop the program.
            //Keep in mind that if the password is still incorrect on the fourth attempt,
            //you should print: "User {username} blocked!".
            //   Then the program stops.

            string userName = Console.ReadLine();
            string password = "";

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }
            int atteps = 0;
            while (atteps < 4)
            {
                string inputPassword = Console.ReadLine();
                atteps++;
                if (inputPassword == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }

                else if (atteps == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                }
                else if (inputPassword != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
