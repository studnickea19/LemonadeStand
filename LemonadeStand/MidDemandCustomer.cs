using System;
namespace LemonadeStand
{
    public class MidDemandCustomer : Customer
    {
        Player player;
        public MidDemandCustomer(Player player)
        {
            this.player = player;
            this.demand = 100;
        }

        //CAN DO
        public override int DemandForTemperature(Weather weather, int demand)
        {
            if (weather.dailyTemperature > 60)
            {
                demand -= 15;
            }
            else if (weather.dailyTemperature < 70)
            {
                demand += 15;
            }
            return demand;
        }

        public override int DemandForConditions(Weather weather, int demand)
        {
            switch (weather.dailyConditions)
            {
                case "sunny":
                    demand += 10;
                    break;
                case "rainy":
                    demand -= 10;
                    break;
                case "overcast":
                    demand -= 10;
                    break;
                case "hazy":
                    demand += 5;
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
                demand -= 15;
            }
            else if (player.pricePerCup < .15)
            {
                demand += 15;
            }
            return demand;
        }

        public override void BuyLemonade(Player player, int demand)
        {
            if (demand >= 60)
            {
                player.SellLemonade(player.pricePerCup);
            }
        }
    }
}
