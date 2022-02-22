using System;

namespace Lesson_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            Console.WriteLine($"a++: {a++}");
            Console.WriteLine($"b--: {b--}");


            int dayOfWeek = 5;
            if (dayOfWeek == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (dayOfWeek == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (dayOfWeek == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (dayOfWeek == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (dayOfWeek == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (dayOfWeek == 6)
            {
                Console.WriteLine("Saturday");
            }
            else
            {
                Console.WriteLine("Sunday");
            }
        }
    }
}
