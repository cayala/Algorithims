using Algorithims.Algorithims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Environment.Exit(0);
        }

        //private void CreateInsertionSort() 
        //{
        //    Random rand = new Random();
        //    int[] unsorted = new int[] { rand.Next(20) };

        //    for (int x = 0; x < unsorted.Length; x++)
        //    {
        //        unsorted[x] = rand.Next();
        //    }
        //    int[] sorted = new int[unsorted.Length];

        //    Console.Write("The follwing unsorted numbers are: ");
        //    foreach (int num in unsorted)
        //    {
        //        Console.Write(num.ToString() + " ");
        //    }
        //    Console.WriteLine(Environment.NewLine);
        //    Console.WriteLine("Sorting now");

        //    sorted = InsertionSort(unsorted, sorted);

        //    Console.Write("Sorting done");
        //    Console.Write("The follwing sorted numbers are: ");
        //    foreach (int num in sorted)
        //    {
        //        Console.Write(num.ToString() + " ");
        //    }

        //    Console.WriteLine("Press any key to exit");
        //    Console.ReadKey();
        //    Environment.Exit(0);
        //}

        //private static int[] InsertionSort(int[] unsorted, int[] sorted)
        //{
        //    //Get the arrays
        //    //then assign the first value of the unsorted to the sorted array
        //    sorted[0] = unsorted[0];
        //    //then we need to loop through the unsorted array starting at the second index
        //    for (int us = 1; us < unsorted.Length; us++)
        //    {
        //        //within the unsorted array loop we need to loop through the sorted array
        //        for (int s = 0; s < sorted.Length; s++)
        //        {
        //            //compare the current unsorted array value to the values in the sorted array

        //            //if the unsorted is less than the first value shift all the sorted values to the right
        //            if (unsorted[us] < sorted[0])
        //            {
        //                //to shift all values to the right
        //                //save the value of the 0 index
        //                int oldValue = sorted[0];

        //                //set the new value of the 0 index
        //                sorted[0] = unsorted[us];

        //                //save the old value of the next index
        //                while (true)
        //                {

        //                }
        //                //and then set it to the old value of the 0 index

        //            }


        //        }
        //    }
        //    //if the unsorted is greater than values before it but less than all the values after it shift left and right
        //    //if the unsorted is greter than all values shift all values left
        //}

    }
}
