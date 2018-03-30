using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LemonadeStand
{
    public class Inventory
    {
        //HAS A
        public List<Lemon> lemons = new List<Lemon>();
        public List<Ice> icecubes = new List<Ice>();
        public List<Sugar> sugars = new List<Sugar>();

        //CTOR
        public Inventory()
        {
        }

        //CAN DO

        //put get methods in store class


        public void AddLemons(int lemonQty, Wallet wallet)
        {
            for (int i = 1; i <= lemonQty; i++)
            {
                if(i<=lemonQty)
                {

                    lemons.Add(new Lemon());
                }
                else
                {
                    return;
                }
            }
            wallet.SpendMoney(lemonQty, Lemon.lemonPrice);

        }




    }
}
