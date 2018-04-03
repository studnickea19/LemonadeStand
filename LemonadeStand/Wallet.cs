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
        public double SpendMoney(double totalCost)
        {
            balance -= totalCost;
            return balance;
        }

        //earn function - takes in lemonade price
        public double EarnMoney(int quantity, double cost)
        {
            balance += quantity * cost;
            return balance;
        }

        public void GetFinalBalance(double balance)
        {
            double finalBalance = 20 - (20 - balance);

            if(finalBalance == 0)
            {
                Message.DisplayMessage("It's a wash");
            }

            else if(finalBalance > 0)
            {
                Message.DisplayMessage("You made money! :) Your final balance is $ " + finalBalance);
            }

            else
            {
                Message.DisplayMessage("You lost money :( Your final balance is $ " + finalBalance);
            }
        }

    }
}
