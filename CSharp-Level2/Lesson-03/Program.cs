using System;
using System.Collections;

namespace Lesson_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new();
            hashtable.Add("book1", "Lesson1");
            hashtable.Add("book2", "Lesson2");
            hashtable.Add("book3", "Lesson3");


            Console.WriteLine(hashtable["book1"]);
            Console.WriteLine(hashtable["book2"]);
            Console.WriteLine(hashtable["book3"]);

        }
    }
}