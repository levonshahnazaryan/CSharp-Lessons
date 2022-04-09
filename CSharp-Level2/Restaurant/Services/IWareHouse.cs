using Restaurant.Models;
using System.Collections.Generic;

namespace Restaurant.Services
{
    public interface IWareHouse
    {
        void ChangeWareCount(string druidName, string name, int count);
        int GetWareCount(string druidName, string name);
        List<FoodStructure> GetFoodsByDruid(string druidName);
        void PrintFoofList(List<FoodStructure> foodList);
    }
}