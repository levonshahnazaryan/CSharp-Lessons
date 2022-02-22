using System;

namespace Lesson_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, can I help you?");
            Console.ReadKey();

            Console.WriteLine("What the Model of car you want to buy?");
            string model = Console.ReadLine();

            Console.WriteLine("Can you tell me price?");
            string price = Console.ReadLine();

            Console.WriteLine("Ok, please confirm the order");
            Console.ReadKey();

            Console.WriteLine($"Your car Model is {model}, please pay the {price}$");
        }
    }
}