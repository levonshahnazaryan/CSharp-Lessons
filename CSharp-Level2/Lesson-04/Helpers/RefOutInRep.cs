using System;

namespace Lesson_04.Helpers
{
    public class RefOutInRep
    {
        public static void ConsRef(ref int number)
        {
            number *= 6;
            Console.WriteLine(number);
        }
        public static void ConsIn(in int number)
        {
            //number = 44; error readonly
            Console.WriteLine(number);
        }
        public static void ConsOut(out int number)
        {
            number = 44;
            Console.WriteLine(number);
        }
        public static void ConsHello(ref string charik)
        {
            Console.WriteLine(charik);
            charik = "Good Bye";
        }
    }
}