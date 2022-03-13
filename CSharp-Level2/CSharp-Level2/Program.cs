using CSharp_Level2.Helpers;
using System;

namespace CSharp_Level2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bubble Sort
            int[] arrayBubble = { 3, 8, 5, 2, 4, 1, 7, 6, 9 };
            Console.Write("Bubble Sort: ");
            var bubble = Extensions.Bubble_Sort(arrayBubble);
            foreach (var item in bubble)
                Console.Write($"{item} ");

            Console.WriteLine("");
            //Selection Sort
            int[] arraySelection = { 3, 8, 5, 2, 4, 1, 7, 6, 9 };
            Console.Write("Selection Sort: ");
            var selecttion = Extensions.Selection_Sort(arraySelection);
            foreach (var item in selecttion)
                Console.Write($"{item} ");

            Console.WriteLine("");
            //Insertion Sort
            int[] arrayInsertion = { 3, 8, 5, 2, 4, 1, 7, 6, 9 };
            Console.Write("Insertion Sort: ");
            var insertion = Extensions.Insertion_Sort(arrayInsertion);
            foreach (var item in insertion)
                Console.Write($"{item} ");


        }
    }
}