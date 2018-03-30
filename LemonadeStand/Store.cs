using System;
namespace LemonadeStand
{
    public class Store
    {
        public Store()
        {
        }

        public int GetLemons()
        {
            Message.DisplayMessage("How many lemons would you like to buy?"); 
            string userInput = Message.GetUserInput();
            //TO DO: VALIDATE
            int lemonQty = Int32.Parse(userInput);
            return lemonQty;
        }

        public int GetIce()
        {
            Message.DisplayMessage("How much ice would you like to buy?"); 
            string userInput = Message.GetUserInput();
            //TO DO: VALIDATE
            int iceQty = Int32.Parse(userInput);
            return iceQty;
        }

        public int GetSugar()
        {
            Message.DisplayMessage("How much sugar would you like to buy?"); 
            string userInput = Message.GetUserInput();
            //TO DO: VALIDATE
            int sugarQty = Int32.Parse(userInput);
            return sugarQty;
        }

        public int GetCups()
        {
            Message.DisplayMessage("How many cups would you like to buy?");
            string userInput = Message.GetUserInput();
            //TO DO: VALIDATE
            int cupQty = Int32.Parse(userInput);
            return cupQty;
        }

        public void GetItems()
        {
            GetLemons();
            GetSugar();
            GetIce();
            GetCups();
        }
    }
}
