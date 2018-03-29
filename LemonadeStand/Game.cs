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
        Player player;
        Weather weather;


        public Game()
        {
            rnd = new Random();
            player = new Player();
            weather = new Weather(rnd);
        }

        public void StartGame()
        {
            //Game Display purpose
            player.SetDaysOfPlay();
            player.PlayForDays(player.daysOfPlay);
            //Game Establish budget
            //Player Fill inventory
            //Game Generate weather
            weather.GetDailyWeather(weather.conditions);
            weather.DisplayDailyWeather();
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
