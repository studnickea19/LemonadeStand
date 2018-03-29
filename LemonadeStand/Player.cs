using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LemonadeStand
{
    public class Player
    {
        //HAS A

        public Player()
        {
        }

        //CAN DO

        public int ChooseLengthOfPlay()
        {
            Console.WriteLine("How long would you like to play? Please choose 7, 14, or 21 days");
            string userInput = Console.ReadLine();
            //TO DO: VALIDATE
            int lengthOfPlay = Int32.Parse(userInput);
            return lengthOfPlay;

        }
    }
}


