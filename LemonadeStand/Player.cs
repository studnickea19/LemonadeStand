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
        Inventory inventory;
        Wallet wallet;

        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
        }

        //CAN DO

        public int SetDaysOfPlay()
        {
            Message.DisplayMessage("How many days would you like to play?");
            string userInput = Message.GetUserInput();
            //TO DO validate user input
            int daysOfPlay = Int32.Parse(userInput);
            return daysOfPlay;
        }

        public void AddLemons(int lemonQty, Wallet wallet)
        {
            for (int i = 1; i <= lemonQty; i++)
            {
                if (i <= lemonQty)
                {

                    inventory.lemons.Add(new Lemon());
                }
                else
                {
                    return;
                }
            }
            wallet.SpendMoney(lemonQty, Lemon.lemonPrice);

        }


    }
}

//TEST
//public void DaysTest()
//{
//    Message.DisplayMessage(daysOfPlay.ToString());
//}


