using System;
using System.Diagnostics;
using System.Linq;
using Sorting;

namespace ArraySorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            
            var randomIntArray = new int[50];
            for (var i = 0; i < randomIntArray.Length; i++)
            {
                randomIntArray[i] = rand.Next(11);
            }

            var arrSorter = new ArraySorter<int>(randomIntArray, 10000);
            arrSorter.SortAscending();
            Console.WriteLine("Sorted Ascending: \n");
            for (var i = 0; i < arrSorter.HeapSize; i++)
            {
                Console.Write($" {arrSorter.Queue[i]}");
            }

            arrSorter.SortDescending();
            Console.WriteLine("\nSorted Descending: \n");
            for (var i = 0; i < arrSorter.HeapSize; i++)
            {
                Console.Write($" {arrSorter.Queue[i]}");
            }
            

            
            
        }
    }
}