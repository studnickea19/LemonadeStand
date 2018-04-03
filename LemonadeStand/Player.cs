﻿using System;
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
        public double pricePerCup;

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
            CheckWallet(price, wallet);
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
            CheckWallet(price, wallet);

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
            CheckWallet(price, wallet);
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
            CheckWallet(price, wallet);

        }

        public void CheckWallet(double price, Wallet wallet)
        {
            if (price <= wallet.balance)
            {
                wallet.SpendMoney(price); 
            }
            else
            {
                Message.DisplayMessage("You don't have enough money! Remaining balace: " + wallet.balance);
            }
        }

        public void SetPrice()
        {
            Message.DisplayMessage("How much would you like to charge per cup?");
            string userInput = Message.GetUserInput();
            //TO DO: VALIDATE
            pricePerCup = Double.Parse(userInput);
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


