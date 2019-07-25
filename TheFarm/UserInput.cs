using System;
using System.Collections.Generic;
using System.Text;

namespace TheFarm
{
    public class UserInput
    {
        public static string GetUserString(string userInput = "test")
        {
            userInput = Console.ReadLine();
            return userInput.ToLower();
        }

        public static int GetUserNumber(int userInput = 1)
        {
            userInput = UserValidation(Console.ReadLine());
            return userInput;
        }

        private static int UserValidation(string valInput)
        {
            string userInput;
            int score;
            bool keepGoing = false;
            do
            {
                keepGoing = int.TryParse(valInput, out score);
                if (!keepGoing || score < 0)
                {
                    Console.WriteLine("  \n\t**Invalid Input**\n  ");
                    Console.Write("  Enter number: ");
                    userInput = Console.ReadLine();
                    keepGoing = int.TryParse(userInput, out score);
                }
            } while (!keepGoing);

            return score;
        }

    }
}
