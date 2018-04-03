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
            customer = new HighDemandCustomer(player);
            Console.WriteLine(customer.demand);
            //customer = new MidDemandCustomer(player);
            //customer = new LowDemandCustomer(player);
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

            }
            player.wallet.GetFinalBalance(player.wallet.balance);
        }

        public void RunGame()
        {
            //Game Generate weather
            string todaysWeather = DisplayDailyWeather(day.weather.conditions);
            Message.DisplayMessage(todaysWeather);

            //Player Fill inventory
            //store.GetItems();
            //player.AddIce(store.iceQty, player.wallet);
            //player.AddCups(store.cupQty, player.wallet);
            //player.AddSugar(store.sugarQty, player.wallet);
            //player.AddLemons(store.lemonQty, player.wallet);
            //Message.DisplayMessage("New balance: $" + player.wallet.balance);

            ////Player set recipe
            //ShowRecipe();
            //GetNewRecipe(player);
            ////Player Set Price
            player.SetPrice();
            customer.demand = customer.DemandForTemperature(day.weather, customer.demand); 
            customer.demand = customer.DemandForConditions(day.weather, customer.demand);
            customer.demand = customer.DemandForPrice(player, customer.demand);
            Message.DisplayMessage("This Customer Demand: " + customer.demand);
            ////player.inventory.GetNewPitcher(player.inventory.pitcher);

            ////Create customers//demand
            ////Increment budget
            ////Reset Ice
            //MeltIce();
            ////Display earnings
            //Message.DisplayMessage("Your new balance is: $" + player.wallet.balance);


        

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

            //TEST CUSTOMER DEMAND
        }


        public string DisplayDailyWeather(List<string> conditions)
        {
            day.GetDailyWeather(conditions);
            string todaysWeather = "Today's Forecast:\n Temperature:" + day.weather.dailyTemperature + "\n Conditions:" + day.weather.dailyConditions;
            return todaysWeather;
        }

        public List<Ice> MeltIce()
        {
            player.inventory.icecubes.Clear();
            return player.inventory.icecubes;
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
            else
            {
                player.SetPrice();
            }

        }

    }
}
