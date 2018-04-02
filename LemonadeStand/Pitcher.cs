using System;
namespace LemonadeStand
{
    public class Pitcher
    {

        public int lemonQty;
        public int sugarQty;
        public int iceQty;

        public Pitcher()
        {

        }



        public int SetLemons()
        {
            Message.DisplayMessage("How many lemons would you like in your recipe?");
            string userInput = Message.GetUserInput();
            //TO DO: VALIDATE
            lemonQty = Int32.Parse(userInput);
            return lemonQty;
        }

        public int SetIce()
        {
            Message.DisplayMessage("How much ice would you like in your recipe?");
            string userInput = Message.GetUserInput();
            //TO DO: VALIDATE
            iceQty = Int32.Parse(userInput);
            return iceQty;
        }

        public int SetSugar()
        {
            Message.DisplayMessage("How many cups of sugar would you like per cup?");
            string userInput = Message.GetUserInput();
            //TO DO: VALIDATE
            sugarQty = Int32.Parse(userInput);
            return sugarQty;
        }

        public void GetRecipe()
        {
            SetLemons();
            SetSugar();
            SetIce();
        }

        public void ShowRecipe()
        {
            Message.DisplayMessage(String.Format("Your current recipe has {0} lemons, {1} cups of sugar, and {2} ice cubes", lemonQty, sugarQty, iceQty));
        }

        public void GetNewRecipe()
        {
            Message.DisplayMessage("Would you like to change your recipe? YES or NO");
            string userInput = Message.GetUserInput().ToLower();
            if( userInput == "yes")
            {
                GetRecipe();
            }
            //else
            //{
            //    SetPrice();
            //}

        }
    }
}



