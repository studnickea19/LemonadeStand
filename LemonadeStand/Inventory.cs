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
        public List<Cup> cups = new List<Cup>();
        public Pitcher pitcher;

        //CTOR
        public Inventory()
        {
            pitcher = new Pitcher();
        }

        //CAN DO

        //put get methods in store class

        public void GetNewPitcher(Pitcher pitcher)
        {
            for (int i = 1; i <= pitcher.lemonQty; i++)
            {
                lemons.RemoveAt(0);
            }
            for (int i = 1; i <= pitcher.sugarQty; i++)
            {
                sugars.RemoveAt(0);
            }
            for (int i = 1; i <= pitcher.iceQty; i++)
            {
                icecubes.RemoveAt(0);
            }
            //for (int i = 1; i <= 10; i++)
            //{
            //    cups.RemoveAt(0);
            //}
        }






    }
}
