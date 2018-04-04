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

        public void GetNewPitcher(Pitcher pitcher, Player player)
        {
            for (int i = 0; i <= pitcher.lemonQty; i++)
            {
                player.inventory.lemons.RemoveAt(0);
                CheckInventory(player.inventory.lemons);
            }
            for (int i = 0; i <= pitcher.sugarQty; i++)
            {
                player.inventory.sugars.RemoveAt(0);
                CheckInventory(player.inventory.lemons);
            }
            for (int i = 0; i <= pitcher.iceQty; i++)
            {
                player.inventory.icecubes.RemoveAt(0);
                CheckInventory(player.inventory.lemons);
            }

        }

        public void CheckInventory(List<Item> listName)
        {
            if (listName.Count == 0)
            {
                EndDay();
            }
        }

    }
}
