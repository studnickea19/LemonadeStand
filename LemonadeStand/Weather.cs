using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LemonadeStand
{
    public class Weather
    {
        //HAS A
        Random rnd;
        public List<string> conditions = new List<string> { "Sunny", "Hazy", "Overcast", "Rainy" };
        public int dailyTemperature;
        public string dailyConditions;
        public string todaysWeather;

        public Weather(Random rnd)
        {
            this.rnd = rnd;
        }

        //CAN DO
        public int GenerateTemp()
        {
            dailyTemperature = rnd.Next(55, 90);
            return dailyTemperature;
        }

        public string GenerateConditions(List<string> conditions)
        {
            //generate random conditions
            int i = rnd.Next(conditions.Count);
            dailyConditions = conditions[i];
            return dailyConditions;
        }

        public void GetDailyWeather(List<string> conditions)
        {
            GenerateTemp();
            GenerateConditions(conditions);
        }

        public string DisplayDailyWeather()
        {
            todaysWeather = "Today's Forecast:\n Temperature:" + dailyTemperature + "\n Conditions:" + dailyConditions;
            return todaysWeather;
        }

        //TEST
        //public void DisplayTest()
        //{
        //    Message.DisplayMessage(dailyTemperature + "\n" + dailyConditions);
        //}


        //MOVE TO CUSTOMER

        //public int DemandforTemperature(Weather dailyTemp)
        //{
        //    //increase/decrease customer demand according to temp
        //}

        //public int DemandforConditions(Weather dailyConditions)
        //{
        //    //increase/decrease customer demand according to conditions
        //}

    }
}
