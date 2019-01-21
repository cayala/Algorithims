using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.Algorithims
{
    public class BinaryArraySearch
    {
        public static void Start()
        {
            Console.WriteLine("Beginning Binary Search");
            Console.WriteLine("Number to search for");
            string searchNum = Console.ReadLine();

            Console.WriteLine("Start Point");

            string startPoint = Console.ReadLine();

            int[] sortedArray = new int[100];
            for (int x = 0; x < sortedArray.Length; x++)
            {
                sortedArray[x] = x;
            }
            BinarySearch(sortedArray, int.Parse(searchNum), int.Parse(startPoint), sortedArray.Length);
        }
        

        public static void BinarySearch(int[] array, int searchNum, int beginRange, int endRange)
        {

            int midPoint = ((endRange - beginRange) / 2) + beginRange;

            if (array[midPoint] == searchNum)
            {
                Console.WriteLine($"Ding number found: {searchNum} at index: {midPoint}");
            }
            else if (searchNum > array[midPoint])
            {
                BinarySearch(array, searchNum, midPoint, endRange);
            }
            else if (searchNum < array[midPoint])
            {
                BinarySearch(array, searchNum, beginRange, midPoint);
            }
        }
    }
}
