using System;
namespace LemonadeStand
{
    public abstract class Customer
    {
        //HAS A
        public int demand;

        //CTOR
        public Customer()
        {
        }

        //CAN DO
        public abstract int DemandForTemperature(Weather weather, int demand);
        public abstract int DemandForConditions(Weather weather, int demand);
        public abstract int DemandForPrice(Player player, int demand);
        public abstract bool BuyLemonade(Player player, int demand);

    }
}
