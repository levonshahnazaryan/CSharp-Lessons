using System;

namespace Lesson_01
{
    public class SeriesX6 : Bmw
    {
        public SeriesX6()
        {

        }

        public SeriesX6(int productionDate, string color, string engineType)
        {
            ProductionDate = productionDate;
            Color = color;
            EngineType = engineType;
        }

        public void GetCarDetails()
        {
            Console.WriteLine($"SeriesX6 car model");
            Console.WriteLine($"SeriesX6 production date is: {ProductionDate}");
            Console.WriteLine($"SeriesX6 color is: {Color}");
            Console.WriteLine($"SeriesX6 engine type is: {EngineType}");
        }
    }
}