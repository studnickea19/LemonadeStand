using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class Message
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static string GetUserInput()
        {
            return Console.ReadLine();
        }

        public static bool CheckIntegerInput(string userInput)
        {
            int value;
            bool isInteger;

            if (int.TryParse(userInput, out value) && value >= 0)
            {
                isInteger = true;
            }
            else
            {
                isInteger = false;
                Message.DisplayMessage("Invalid input! Please enter a number");
            }
            return isInteger;
        }

    }
}
