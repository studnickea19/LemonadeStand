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

        public Day(Random rnd)
        {
            this.rnd = rnd;
            weather = new Weather(rnd);
        }

        //CAN DO
        public void GetDailyWeather(List<string> conditions)
        {
            weather.GetTemperature();
            weather.GetConditions(conditions);

        }





    }
}
