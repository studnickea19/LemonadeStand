using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LemonadeStand
{
    public class Game
    {
        //HAS A________________
        Random rnd;
        Player player;
        public Day day;
        Store store;

        //CTOR__________________
        public Game()
        {
            rnd = new Random();
            player = new Player();
            day = new Day(rnd);
            store = new Store();

        }

        //CAN DO________________
        public void StartGame()
        {
            //TO DO: Game Display purpose
            //Message.DisplayMessage("You have $20 to start with. Buy items to fill your inventory.")
            int daysOfPlay = player.SetDaysOfPlay();
            PlayForDays(daysOfPlay);
        }

        public void PlayForDays(int daysOfPlay)
        {
            for (int d = 1; d <= daysOfPlay; d++)
            {
                    RunGame();   
            }
            //TO DO: run formula to calculate total
            
        }

        public void RunGame()
        {
            //Game Generate weather
            string todaysWeather = DisplayDailyWeather(day.weather.conditions);
            Message.DisplayMessage(todaysWeather);

            //Game Establish budget
            Message.DisplayMessage("You have $" + player.wallet.balance);

            //Player Fill inventory
            //store.GetItems();
            //Message.DisplayMessage("You now have $" + player.wallet.balance);


            //Player set recipe
            //TO DO: QTY of each items
            //TO DO: Decrement inventory

            //Player Set Price
            //Create customers//demand
            //Increment budget
            //Reset Ice
            //Display earnings

            //TESTS //working
            //weather.DisplayTest();
            //int lemonQty = inventory.GetLemons();
            //inventory.AddLemons(lemonQty, wallet);
            //Console.WriteLine(wallet.balance);
        }

        public string DisplayDailyWeather(List<string> conditions)
        {
            day.GetDailyWeather(conditions);
            string todaysWeather = "Today's Forecast:\n Temperature:" + day.weather.dailyTemperature + "\n Conditions:" + day.weather.dailyConditions;
            return todaysWeather;
        }

    }
}
