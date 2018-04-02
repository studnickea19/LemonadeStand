using System;
namespace LemonadeStand
{
    public abstract class Customer
    {
        //HAS A
        int demand;

        //CTOR
        public Customer()
        {
        }

        //CAN DO
        public abstract int DemandForTemperature(Weather weather, int demand);
        public abstract int DemandForConditions(Weather weather, int demand);
        public abstract void BuyLemonade(Player player, int demand);

    }
}
