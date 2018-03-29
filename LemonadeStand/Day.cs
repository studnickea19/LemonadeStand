using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LemonadeStand
{
    public class Day
    {
        //HAS A
        Random rnd;
        Weather weather;
        public int daysOfPlay;

        public Day()
        {
            rnd = new Random();
            weather = new Weather(rnd);
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

        public void DaysTest()
        {
            Message.DisplayMessage(daysOfPlay.ToString());
        }



    }
}
