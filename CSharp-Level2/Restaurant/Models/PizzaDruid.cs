using Restaurant.Enums;
using System;

namespace Restaurant.Models
{
    public class PizzaDruid : DruidClabBase
    {
        public PizzaDruid()
        {
            Name = RestorantNames.PizzaDruid.ToString();
        }
        public override string Name { get; set; }

        public void SetOrder(int count)
        {
            Console.WriteLine($"\nWelcome to Restorant {Name}");
            var foods = wareHouse.GetFoodsByDruid(Name);
            Console.WriteLine($"The Food list in {Name} Restorant is: ");
            wareHouse.PrintFoofList(foods);

            for (int i = 0; i < count; i++)
            {
                foreach (var item in foods)
                {
                    wareHouse.ChangeWareCount(item.DruidName, item.Name, 1);
                }
            }

            Console.WriteLine($"The Food balance in {Name} Restorant is: ");
            wareHouse.PrintFoofList(foods);
        }
    }
}