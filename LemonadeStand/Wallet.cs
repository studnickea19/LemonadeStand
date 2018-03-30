using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LemonadeStand
{
    public class Wallet
    {
        //HAS A

        public double balance;

        //CONSTRUCTOR
        public Wallet()
        {
            balance = 20.00;
        }

        //CAN DO
        //spend function - take in costs

        public double SpendMoney(int quantity, double cost)
        {
            balance -= quantity * cost;
            return balance;
        }

        //earn function - takes in lemonade price
        public double EarnMoney(int quantity, double cost)
        {
            balance += quantity * cost;
            return balance;
        }

    }
}
