using Restaurant.Enums;
using Restaurant.Models;
using System;
using System.Collections.Generic;

namespace Restaurant.Services
{
    public class WareHouse : IWareHouse
    {
        public List<FoodStructure> FoodStructure = new();
        public WareHouse()
        {
            AddWareHouse();
        }
        private void AddWareHouse()
        {
            FoodStructure.Add(new FoodStructure { DruidName = RestorantNames.PizzaDruid.ToString(), Name = FoodNames.Eggs.ToString(), Count = 20 });
            FoodStructure.Add(new FoodStructure { DruidName = RestorantNames.PizzaDruid.ToString(), Name = FoodNames.Flour.ToString(), Count = 10 });
            FoodStructure.Add(new FoodStructure { DruidName = RestorantNames.PizzaDruid.ToString(), Name = FoodNames.Salt.ToString(), Count = 70 });
            FoodStructure.Add(new FoodStructure { DruidName = RestorantNames.PizzaDruid.ToString(), Name = FoodNames.Pepperoni.ToString(), Count = 30 });
            FoodStructure.Add(new FoodStructure { DruidName = RestorantNames.PizzaDruid.ToString(), Name = FoodNames.Oil.ToString(), Count = 22 });

            FoodStructure.Add(new FoodStructure { DruidName = RestorantNames.CafeDruid.ToString(), Name = FoodNames.Coffee.ToString(), Count = 50 });
            FoodStructure.Add(new FoodStructure { DruidName = RestorantNames.CafeDruid.ToString(), Name = FoodNames.Water.ToString(), Count = 100 });
            FoodStructure.Add(new FoodStructure { DruidName = RestorantNames.CafeDruid.ToString(), Name = FoodNames.Sugar.ToString(), Count = 30 });

            FoodStructure.Add(new FoodStructure { DruidName = RestorantNames.RestDruid.ToString(), Name = FoodNames.Chickens.ToString(), Count = 12 });
            FoodStructure.Add(new FoodStructure { DruidName = RestorantNames.RestDruid.ToString(), Name = FoodNames.Potatoes.ToString(), Count = 20 });
        }
        public void ChangeWareCount(string druidName, string name, int count)
        {
            foreach (var item in FoodStructure)
            {
                if (item.DruidName == druidName && item.Name == name)
                {
                    int cnt = item.Count - count;
                    if (item.Count < 0)
                    {
                        throw new Exception($"There is not enough stock for {name}: {item.Count}");
                    }
                    else
                    {
                        item.Count -= count;
                        break;
                    }
                }
            }
        }
        public int GetWareCount(string druidName, string name)
        {
            int count = 0;
            foreach (var item in FoodStructure)
            {
                if (item.DruidName == druidName && item.Name == name)
                {
                    count = item.Count;
                }
            }
            return count;
        }

        public List<FoodStructure> GetFoodsByDruid(string druidName)
        {
            List<FoodStructure> foods = new();
            foreach (var item in FoodStructure)
            {
                if (item.DruidName == druidName)
                    foods.Add(item);
            }
            return foods;
        }
        public void PrintFoofList(List<FoodStructure> foodList)
        {
            foreach (var item in foodList)
            {
                Console.WriteLine($"{item.Name}: {item.Count}");
            }
        }
    }
}