using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LemonadeStand
{
    public class Day
    {
        //HAS A
        Random rnd;
        Weather weather;
        public int daysOfPlay;

        public Day()
        {
            rnd = new Random();
            weather = new Weather(rnd);
        }

        //CAN DO




    }
}
