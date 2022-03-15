using Lesson_01.Helpers;
using System;

namespace Lesson_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Series4 series4 = new();
            series4.ProductionDate = 2021;
            series4.Color = CarColors.Black.ToString();
            series4.EngineType = CarEngineType.Benzin.ToString();
            series4.GetCarDetails();

            Console.WriteLine("----------------------------------------------");

            SeriesX6 seriesX6 = new();
            seriesX6.ProductionDate = 2023;
            seriesX6.Color = CarColors.Yellow.ToString();
            seriesX6.EngineType = CarEngineType.Diesel.ToString();
            seriesX6.GetCarDetails();

            Console.WriteLine("-----------With Parametors in to Constructor-------------------");

            Series4 cSeries4 = new(2014, CarColors.Green.ToString(), CarEngineType.Benzin.ToString());
            cSeries4.GetCarDetails();

            Console.WriteLine("----------------------------------------------");

            SeriesX6 cSeriesX6 = new(2000, CarColors.Red.ToString(), CarEngineType.Diesel.ToString());
            cSeriesX6.GetCarDetails();


            Console.WriteLine("Press Any Key to Exit..");
            Console.ReadLine();
        }
    }
}

//GBLessson
//Boxing UnBoxing