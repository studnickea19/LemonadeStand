﻿using System;
namespace LemonadeStand
{
    public class HighDemandCustomer : Customer
    {
        Player player;
        public HighDemandCustomer(Player player)
        {
            this.player = player;
            this.demand = 100;
        }

        //CAN DO
        public override int DemandForTemperature(Weather weather, int demand)
        {
            if (weather.dailyTemperature > 70)
            { 
                demand += 20; 
            }
            else if (weather.dailyTemperature < 60)
            {
                demand -= 10;
            }
            return demand;
        }

        public override int DemandForConditions(Weather weather, int demand)
        {
            switch (weather.dailyConditions)
            {
                case "sunny":
                    demand += 20;
                    break;
                case "rainy":
                    demand -= 10;
                    break;
                case "overcast":
                    demand -= 5;
                    break;
                case "hazy":
                    demand += 10;
                    break;
                default:
                    break;
            }
            return demand;
        }

        public override int DemandForPrice(Player player, int demand)
		{
            if(player.pricePerCup > .3)
            {
                demand -= 10;
            }
            else if(player.pricePerCup < .15)
            {
                demand += 20;
            }
            return demand;
		}

        public override bool BuyLemonade(Player player, int demand)
        {
            bool buy;
            if (demand >= 75)
            {
                buy = true;
                player.cupsSold++;
            }
            else
            {
                buy = false;
            }
            return buy;
        }
    }
}
