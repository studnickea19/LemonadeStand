using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LemonadeStand
{
    public class Game
    {
        Random rnd;
        Day day;
        Weather weather;


        public Game()
        {
            rnd = new Random();
            day = new Day();
            weather = new Weather(rnd);
        }

        public void RunGame()
        {
            //Game Display purpose
            day.SetDaysOfPlay();
            //Game Establish budget
            //Player Fill inventory
            //Game Generate weather
            weather.GenerateTemp();
            weather.GenerateConditions(weather.conditions);
            //Player Set Price
            //Create customers//demand
            //Play Game
            //Decrement inventory
            //Increment budget
            //Reset Ice
            //Display earnings
            //Increment day

            //TESTS //working
            //weather.DisplayTest();
            //day.DaysTest();
            
        }
    }
}
