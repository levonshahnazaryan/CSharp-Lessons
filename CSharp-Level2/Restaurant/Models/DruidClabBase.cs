using Restaurant.Enums;
using Restaurant.Services;
using System;

namespace Restaurant.Models
{
    public class DruidClabBase
    {
        public readonly IWareHouse wareHouse;
        public MainDelegate mainDelegate;
        public DruidClabBase()
        {
            wareHouse = new WareHouse();
        }
        public virtual string Name { get; set; }

        public string GetRestorant()
        {
            Console.WriteLine("Please choose the restorant");
            var restList = Helpers.Extensions.GetEnumsValues<RestorantNames>();
            foreach (var item in restList)
            {
                Console.WriteLine($"{(int)item}: {item}");
            }

            string rest = Console.ReadLine();
            int.TryParse(rest, out int restNumber);
            string restName = "";
            foreach (var item in restList)
            {
                if ((int)item == restNumber)
                {
                    restName = item.ToString();
                    break;
                }
            }
            return restName;
        }
    }
}