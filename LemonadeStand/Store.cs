using System;
namespace LemonadeStand
{
    public class Store
    {
        public int lemonQty;
        public int sugarQty;
        public int iceQty;
        public int cupQty;
        Player player;

        public Store(Player player)
        {
            this.player = player;
        }

        public int GetLemons()
        {
            Message.DisplayMessage("How many lemons would you like to buy?"); 
            string userInput = Message.GetUserInput();
            bool check = Message.CheckIntegerInput(userInput);

            if(check == true)
            {
                lemonQty = Int32.Parse(userInput);  
            }
            else
            {
                GetLemons();
            }

            return lemonQty;
        }

        public int GetIce()
        {
            Message.DisplayMessage("How much ice would you like to buy?"); 
            string userInput = Message.GetUserInput();
            bool check = Message.CheckIntegerInput(userInput);

            if (check == true)
            {
                iceQty = Int32.Parse(userInput);
            }
            else
            {
                GetIce();
            }

            return iceQty;
        }

        public int GetSugar()
        {
            Message.DisplayMessage("How many cups of sugar would you like to buy?"); 
            string userInput = Message.GetUserInput();
            bool check = Message.CheckIntegerInput(userInput);

            if (check == true)
            {
                sugarQty = Int32.Parse(userInput);
            }
            else
            {
                GetSugar();
            }

            return sugarQty;
        }

        public int GetCups()
        {
            Message.DisplayMessage("How many cups would you like to buy?");
            string userInput = Message.GetUserInput();
            bool check = Message.CheckIntegerInput(userInput);

            if (check == true)
            {
                cupQty = Int32.Parse(userInput);
            }
            else
            {
                GetCups();
            }

            return iceQty;
        }

    }
}
