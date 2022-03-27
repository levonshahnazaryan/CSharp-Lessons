using System;
using System.Collections;
using System.Collections.Generic;

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

            hashtable["book1"] = "Hello";
            hashtable.Remove("book2");


            Console.WriteLine(hashtable["book1"]);
            Console.WriteLine(hashtable["book2"]);
            Console.WriteLine(hashtable["book3"]);

            hashtable.Clear();


            List<int?> aa = new List<int?>();
            aa.Add(null);



            SortedList<string, string> fffff = new();
            fffff.Add("vaaaa", "aaaa");
            fffff.Add("baaa", "aaaa");
            fffff.Add("caaa", "aaaa");
            fffff.Add("daaa", "aaaa");

            LinkedList<string> aaaa = new();

            aaaa.AddFirst("1");
            aaaa.AddFirst("2");
            aaaa.AddLast("88");
            aaaa.AddLast("99");
            aaaa.AddFirst("3");
            aaaa.AddFirst("4");
            aaaa.AddFirst("5");
        }
    }
}