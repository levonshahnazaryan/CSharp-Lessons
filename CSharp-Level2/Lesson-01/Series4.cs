using System;

namespace Lesson_01
{
    public class Series4 : Bmw
    {
        public void GetCarDetails()
        {
            Console.WriteLine($"Series4 car model");
            Console.WriteLine($"Series4 production date is: {ProductionDate}");
            Console.WriteLine($"Series4 color is: {Color}");
            Console.WriteLine($"Series4 engine type is: {EngineType}");
        }
    }
}