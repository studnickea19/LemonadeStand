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
        public List<string> conditions = new List<string> { "sunny", "hazy", "overcast", "rainy" };
        public int dailyTemperature;
        public string dailyConditions;

        public Weather(Random rnd)
        {
            this.rnd = rnd;
        }

        //CAN DO
        public int GetTemperature()
        {
            dailyTemperature = rnd.Next(55, 90);
            return dailyTemperature;
        }

        public string GetConditions(List<string> conditions)
        {
            //generate random conditions
            int i = rnd.Next(conditions.Count);
            dailyConditions = conditions[i];
            return dailyConditions;
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
