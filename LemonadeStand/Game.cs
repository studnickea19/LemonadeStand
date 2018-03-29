﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LemonadeStand
{
    public class Game
    {
        Random rnd;
        Weather weather;

        public Game()
        {
            rnd = new Random();
            weather = new Weather(rnd);
        }

        public void RunGame()
        {
            

            //Game Display purpose
            //Game Establish budget
            //Player Fill inventory
            //Game Generate weather
            weather.GenerateTemp();
            weather.GenerateConditions(weather.conditions);
            //Player Set Price
            //Create customers//demand
            //Play Game
                //Decrement inventory
                //Increment budget
                //Reset Ice
                //Display earnings
                //Increment day
            weather.DisplayTest();
            
        }
    }
}