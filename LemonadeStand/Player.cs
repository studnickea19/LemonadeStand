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
        public int daysOfPlay;

        public Player()
        {
        }

        //CAN DO

        public int SetDaysOfPlay()
        {
            Message.DisplayMessage("How many days would you like to play?");
            string userInput = Message.GetUserInput();
            //TO DO validate user input
            daysOfPlay = Int32.Parse(userInput);
            return daysOfPlay;
        }

        public void PlayForDays(int daysOfPlay)
        {
            for (int d = 1; d <= daysOfPlay; d++)
            {
                if(d <= daysOfPlay)
                {
                    //Game game RunGame();
                }
                else
                {
                    //run formula to calculate total
                }
                    
            }
        }

        //TEST
        //public void DaysTest()
        //{
        //    Message.DisplayMessage(daysOfPlay.ToString());
        //}
    }
}


