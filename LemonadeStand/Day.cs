using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LemonadeStand
{
    public abstract class Day
    {
        //HAS A
        Random rnd;
        public int dayCount;
        Weather weather;

        public Day()
        {
            weather = new Weather(rnd);
        }

        //CAN DO

    }
}
