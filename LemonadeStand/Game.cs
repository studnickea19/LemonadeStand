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
        Customer customer;

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
            int daysOfPlay = player.SetDaysOfPlay();
            //Message.DisplayMessage("You have $20 to start with. Buy items to fill your inventory.")
            PlayForDays(daysOfPlay);

        }

        public void PlayForDays(int daysOfPlay)
        {
            for (int d = 1; d <= daysOfPlay; d++)
            {
                RunGame();
                Message.DisplayMessage("Your current balance is: $" + player.wallet.balance);

            }
            player.wallet.GetFinalBalance(player.wallet.balance);
        }

        public void RunGame()
        {
            //Game Generate weather
            string todaysWeather = DisplayDailyWeather(day.weather.conditions);
            Message.DisplayMessage(todaysWeather);

            //Player Fill inventory
            store.GetItems();
            player.AddIce(store.iceQty, player.wallet);
            player.AddCups(store.cupQty, player.wallet);
            player.AddSugar(store.sugarQty, player.wallet);
            player.AddLemons(store.lemonQty, player.wallet);
            Message.DisplayMessage("New balance: $" + player.wallet.balance);

            //Player set recipe
            player.inventory.pitcher.ShowRecipe();
            player.inventory.pitcher.GetNewRecipe();
            //Player Set Price
            player.SetPrice();
            //player.inventory.GetNewPitcher(player.inventory.pitcher);

            //Create customers//demand
            //Increment budget
            //Reset Ice
            //Display earnings

        

            //TESTS //working
            //weather.DisplayTest();
            //int lemonQty = inventory.GetLemons();
            //inventory.AddLemons(lemonQty, wallet);
            //Console.WriteLine(wallet.balance);
            //Console.WriteLine(player.inventory.cups.Count + player.inventory.icecubes.Count + player.inventory.lemons.Count + player.inventory.sugars.Count);
            //Console.WriteLine(player.inventory.cups.Count + player.inventory.icecubes.Count + player.inventory.lemons.Count + player.inventory.sugars.Count);
            //TEST INPUT
            //Console.WriteLine("Enter a number");
            //string userInput = Console.ReadLine();
            //bool isInteger = Message.CheckIntegerInput(userInput);
            //Console.WriteLine(isInteger);
        }


        public string DisplayDailyWeather(List<string> conditions)
        {
            day.GetDailyWeather(conditions);
            string todaysWeather = "Today's Forecast:\n Temperature:" + day.weather.dailyTemperature + "\n Conditions:" + day.weather.dailyConditions;
            return todaysWeather;
        }

        public void PlayAgain(string start)
        {
            if (start == "start")
            {
                StartGame();
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
            }
        }

    }
}
