using CSharp_Level2.Helpers;
using System;

namespace CSharp_Level2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 8, 5, 2, 4, 1, 7, 6, 9 };

            //Bubble Sort
            var bubble = Extensions.Bubble_Sort(array);
            foreach (var item in bubble)
                Console.Write($"{item} ");


        }
    }
}