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
        public abstract int NewDemand();
        public abstract int BuyLemonade();

    }
}
