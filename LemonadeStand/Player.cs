using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LemonadeStand
{
    public class Player
    {
        //HAS A
        public Inventory inventory;
        public Wallet wallet;

        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
        }

        //CAN DO

        public int SetDaysOfPlay()
        {
            int daysOfPlay;
            Message.DisplayMessage("How many days would you like to play?");
            string userInput = Message.GetUserInput();
            bool check = Message.CheckIntegerInput(userInput);

            if (check == true)
            {
                daysOfPlay = Int32.Parse(userInput);

            }
            else
            {
                return SetDaysOfPlay();

            }
            return daysOfPlay;

        }

        public void AddLemons(int lemonQty, Wallet wallet)
        {
            double price = 0;
            for (int i = 1; i <= lemonQty; i++)
            {
                    Lemon lemon = new Lemon();
                    inventory.lemons.Add(lemon);
                    price += lemon.itemPrice;
            }
            bool haveMoney = CheckWallet(price, wallet);
            AccessWallet(haveMoney, price);
        }

        public void AddCups(int cupQty, Wallet wallet)
        {
            double price = 0;
            for (int i = 1; i <= cupQty; i++)
            {
                    Cup cup = new Cup();
                    inventory.cups.Add(cup);
                    price += cup.itemPrice;
            }
            bool haveMoney = CheckWallet(price, wallet);
            AccessWallet(haveMoney, price);

        }

        public void AddSugar(int sugarQty, Wallet wallet)
        {
            double price = 0;
            for (int i = 1; i <= sugarQty; i++)
            {
                    Sugar sugar = new Sugar();
                    inventory.sugars.Add(sugar);
                    price += sugar.itemPrice;
            }
            bool haveMoney = CheckWallet(price, wallet);
            AccessWallet(haveMoney, price);
        }

        public void AddIce(int iceQty, Wallet wallet)
        {
            double price = 0;
            for (int i = 1; i <= iceQty; i++)
            {
                    Ice ice = new Ice();
                    inventory.icecubes.Add(ice);
                    price += ice.itemPrice;
            }
            bool haveMoney = CheckWallet(price, wallet);
            AccessWallet(haveMoney, price);
        }

        public bool CheckWallet(double price, Wallet wallet)
        {
            bool haveMoney;
            if (price <= wallet.balance)
            {
                haveMoney = true;
            }
            else
            {
                haveMoney = false;
            }
            return haveMoney; 
        }

        public void AccessWallet(bool haveMoney, double price)
        {
            if(haveMoney == true)
            {
                wallet.SpendMoney(price); 
            }

            else
            {
                Message.DisplayMessage("You don't have enough money! Remaining balace: " + wallet.balance);
            }
        }

        public double SetPrice()
        {
            Message.DisplayMessage("How much would you like to charge per cup?");
            string userInput = Message.GetUserInput();
            //TO DO: VALIDATE
            double pricePerCup = Double.Parse(userInput);
            return pricePerCup;
        }

        public double SellLemonade(double pricePerCup)
        {
            wallet.balance += pricePerCup;
            return wallet.balance;
        }
    }
}

//TEST
//public void DaysTest()
//{
//    Message.DisplayMessage(daysOfPlay.ToString());
//}


