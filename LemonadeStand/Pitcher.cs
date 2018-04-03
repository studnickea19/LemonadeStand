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
            bool check = Message.CheckIntegerInput(userInput);
            if (check == true)
            {
                lemonQty = Int32.Parse(userInput);
            }
            else
            {
                return SetLemons();
            }

            return lemonQty;
        }

        public int SetIce()
        {
            Message.DisplayMessage("How much ice would you like per cup?");
            string userInput = Message.GetUserInput();
            bool check = Message.CheckIntegerInput(userInput);
            if (check == true)
            {
                iceQty = Int32.Parse(userInput)*10; //10cups per pitcher
            }

            else
            {
                return SetIce();
            }   
            return iceQty;
        }

        public int SetSugar()
        {
            Message.DisplayMessage("How many cups of sugar would you like in your recipe?");
            string userInput = Message.GetUserInput();
            bool check = Message.CheckIntegerInput(userInput);
            if (check == true)
            {
                sugarQty = Int32.Parse(userInput);
            }
            else
            {
                return SetSugar();
            }
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



