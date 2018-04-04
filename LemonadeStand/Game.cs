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
        double spentBalance = 0;

        //CTOR__________________
        public Game()
        {
            rnd = new Random();
            player = new Player();
            day = new Day(rnd, player);
            store = new Store(player);
        }

        //CAN DO________________
        public void StartGame()
        {
            //TO DO: Game Display purpose
            day.AddCustomerTypes();
            int daysOfPlay = player.SetDaysOfPlay();
            Message.DisplayMessage("You have $20 to start with. Buy items to fill your inventory.");
            PlayForDays(daysOfPlay);

        }

        public void PlayForDays(int daysOfPlay)
        {
            double earnedBalance;
            for (int d = 1; d <= daysOfPlay; d++)
            {
                RunGame();
                earnedBalance = GetIncome(spentBalance);
            }
            player.wallet.GetFinalBalance(player.wallet.balance);
        }

        public void RunGame()
        {
            //Game Generate weather
            string todaysWeather = DisplayDailyWeather(day.weather.conditions);
            Message.DisplayMessage(todaysWeather);

            //Player Fill inventory
            Message.DisplayMessage(String.Format("Your current inventory is {0} lemons, {1} cups of sugar, and {2} cups", player.inventory.lemons.Count, player.inventory.sugars.Count, player.inventory.cups.Count));
            store.GetLemons();
            player.AddLemons(store.lemonQty, player.wallet);
            Message.DisplayMessage("New balance: $" + player.wallet.balance);
            store.GetSugar();
            player.AddSugar(store.sugarQty, player.wallet);
            Message.DisplayMessage("New balance: $" + player.wallet.balance);
            store.GetIce();
            player.AddIce(store.iceQty, player.wallet);
            Message.DisplayMessage("New balance: $" + player.wallet.balance);
            store.GetCups();
            player.AddCups(store.cupQty, player.wallet);
            Message.DisplayMessage("New balance: $" + player.wallet.balance);
            spentBalance = 20 - player.wallet.balance;

            //Player set recipe
            ShowRecipe();
            GetNewRecipe(player);

            //Player Set Price
            player.SetPrice();
            player.inventory.GetNewPitcher(player.inventory.pitcher);

            //Create customers//demand
            int customerQty = day.GetCustomerQty();
            day.GenerateCustomer(customerQty);
            day.GetDemand();

            //End day
            day.EndDay();

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
            //Message.DisplayMessage("This Customer Demand: " + customer.demand);
            //TEST CUSTOMER DEMAND
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

        public void GetRecipe()
        {
            player.inventory.pitcher.SetLemons();
            player.inventory.pitcher.SetSugar();
            player.inventory.pitcher.SetIce();
        }

        public void ShowRecipe()
        {
            Message.DisplayMessage(String.Format("Your current recipe has {0} lemons, {1} cups of sugar, and {2} ice cubes", player.inventory.pitcher.lemonQty, player.inventory.pitcher.sugarQty, player.inventory.pitcher.iceQty));
        }

        public void GetNewRecipe(Player player)
        {
            Message.DisplayMessage("Would you like to change your recipe? YES or NO");
            string userInput = Message.GetUserInput().ToLower();
            if (userInput == "yes")
            {
                GetRecipe();
            }
            else if (userInput == "no")
            {
                player.SetPrice();
            }
            else
            {
                Message.DisplayMessage("Invalid input!");
                GetNewRecipe(player);
            }

        }

        public double GetIncome(double spentBalance)
        {
            double earnedBalance = player.wallet.balance - spentBalance;
            return earnedBalance;
        }

    }
}
