using System;
namespace LemonadeStand
{
    public class LowDemandCustomer : Customer
    {
        //HAS A
        Player player;

        //CTOR
        public LowDemandCustomer(Player player)
        {
            this.player = player;
            this.demand = 100;
        }

        //CAN DO
        public override int DemandForTemperature(Weather weather, int demand)
        {
            if (weather.dailyTemperature > 60)
            {
                demand -= 30;
            }
            else if (weather.dailyTemperature < 75)
            {
                demand += 10;
            }
            return demand;
        }

        public override int DemandForConditions(Weather weather, int demand)
        {
            switch (weather.dailyConditions)
            {
                case "sunny":
                    demand += 5;
                    break;
                case "rainy":
                    demand -= 30;
                    break;
                case "overcast":
                    demand -= 15;
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
            if (player.pricePerCup > .3)
            {
                demand -= 20;
            }
            else if (player.pricePerCup < .15)
            {
                demand += 10;
            }
            return demand;
        }


        public override void BuyLemonade(Player player, int demand)
        {
            if (demand >= 70)
            {
                player.SellLemonade(player.pricePerCup);
                player.cupsSold++;
            }
        }




    }
}
