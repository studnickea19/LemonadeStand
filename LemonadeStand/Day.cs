﻿using System;
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
        Player player;
        public Weather weather;
        public List<Customer> customers = new List<Customer>();
        public List<Customer> customerType = new List<Customer> ();

        public Day(Random rnd, Player player)
        {
            this.rnd = rnd;
            this.player = player;
            weather = new Weather(rnd);
        }

        //CAN DO

        public void AddCustomerTypes()
        {
            customerType.Add(new HighDemandCustomer(player));
            customerType.Add(new MidDemandCustomer(player));
            customerType.Add(new LowDemandCustomer(player));
        }

        public void GetDailyWeather(List<string> conditions)
        {
            weather.GetTemperature();
            weather.GetConditions(conditions);

        }

        public int GetCustomerQty()
        {
            int customerQty = 0;

            if (weather.dailyTemperature > 80 && weather.dailyConditions == "sunny")
            {
                customerQty = 105;
            }
            else if (weather.dailyTemperature > 70 && weather.dailyConditions == "rainy")
            {
                customerQty = 96;
            }
            else if (weather.dailyTemperature <= 60 && weather.dailyConditions == "rainy")
            {
                customerQty = 68;
            }
            else if (weather.dailyTemperature > 70 && weather.dailyConditions == "overcast")
            {
                customerQty = 77;
            }
            else
            {
                customerQty = 65;
            }
            return customerQty;
        }

        public void GenerateCustomer(int customerQty)
        {
            for (int i = 1; i <= customerQty; i++)
            {
                int c = rnd.Next(customerType.Count);
                Customer customer = customerType[c];
                customers.Add(customer);
            }
        }

        public void GetDemand()
        {
            foreach(Customer customer in customers)
            {
                customer.demand = customer.DemandForTemperature(weather, customer.demand);
                customer.demand = customer.DemandForConditions(weather, customer.demand);
                customer.demand = customer.DemandForPrice(player, customer.demand);
                customer.BuyLemonade(player, customer.demand);
            }

        }
            
    }
}
