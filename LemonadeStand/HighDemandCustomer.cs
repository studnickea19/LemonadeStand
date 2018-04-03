using System;
namespace LemonadeStand
{
    public class HighDemandCustomer : Customer
    {
        Player player;
        public HighDemandCustomer(Player player)
        {
            this.player = player;
            int demand = 90;
        }

        //CAN DO
        public override int DemandForTemperature(Weather weather, int demand)
        {
            if (weather.dailyTemperature > 60)
            { 
                demand -= 10; 
            }
            else if (weather.dailyTemperature < 70)
            {
                demand += 20;
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


        public override void BuyLemonade(Player player, int demand)
        {
            if (demand >= 70)
            {
                player.SellLemonade(player.pricePerCup);
            }
        }
    }
}
