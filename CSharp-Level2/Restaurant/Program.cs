using Restaurant.Enums;
using Restaurant.Models;
using System;

namespace Restaurant
{
    public delegate void MainDelegate(int count);
    class Program
    {
        static void Main(string[] args)
        {
            DruidClabBase druid = new();
            string druidName = druid.GetRestorant();

            if (druidName == RestorantNames.PizzaDruid.ToString() || druidName == RestorantNames.All.ToString())
            {
                PizzaDruid pizza = new();
                if (druid.mainDelegate == null)
                    druid.mainDelegate = new MainDelegate(pizza.SetOrder);
                else
                    druid.mainDelegate += pizza.SetOrder;
            }
            if (druidName == RestorantNames.CafeDruid.ToString() || druidName == RestorantNames.All.ToString())
            {
                CafeDruid pizza = new();
                if (druid.mainDelegate == null)
                    druid.mainDelegate = new MainDelegate(pizza.SetOrder);
                else
                    druid.mainDelegate += pizza.SetOrder;
            }

            if (druidName == RestorantNames.RestDruid.ToString() || druidName == RestorantNames.All.ToString())
            {
                RestDruid pizza = new();
                if (druid.mainDelegate == null)
                    druid.mainDelegate = new MainDelegate(pizza.SetOrder);
                else
                    druid.mainDelegate += pizza.SetOrder;
            }

            Console.WriteLine("\nPlease confirm the count");
            string rest = Console.ReadLine();
            int.TryParse(rest, out int restNumber);
            druid.mainDelegate(restNumber);
        }
    }
}