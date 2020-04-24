using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.Algorithims
{
    public class QuickSort
    {
        public static int GetMinimum(int[,] numbers)
        {
            int[] minimums = new int[0];
            int sum = 0;

            for (int index = 0; index < numbers.GetLength(0); index++)
            {

                int[] dimensionArray = new int[0];

                for (int x = 0; x < numbers.GetLength(1); x++)
                {
                    dimensionArray = Append(dimensionArray, numbers[index, x]);
                }

                dimensionArray = QuickSortArray(dimensionArray);
                minimums = Append(minimums, dimensionArray[0]);
            }


            for (int index = 0; index < minimums.Length; index++)
            {
                sum += minimums[index];
            }

            return sum;
        }
        public static int[] QuickSortArray(int[] array)
        {
            //divide
            int pivot = array[0];

            int[] lessThanPivot = new int[0];
            int[] greaterThanPivot = new int[0];

            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] < pivot)
                {
                    lessThanPivot = Push(lessThanPivot, array[index]);
                }
                else if (array[index] > pivot)
                {
                    greaterThanPivot = Push(greaterThanPivot, array[index]);
                }
            }
            //conquer
            if (!Sorted(lessThanPivot))
                lessThanPivot = QuickSortArray(lessThanPivot);
            if (!Sorted(greaterThanPivot))
                greaterThanPivot = QuickSortArray(greaterThanPivot);
            //combine
            int[] sortedArray = new int[lessThanPivot.Length];
            for (int index = 0; index < lessThanPivot.Length; index++)
            {
                sortedArray[index] = lessThanPivot[index];
            }

            sortedArray = Append(sortedArray, pivot);

            for (int index = 0; index < greaterThanPivot.Length; index++)
            {
                sortedArray = Append(sortedArray, greaterThanPivot[index]);
            }
            return sortedArray;
        }

        public static bool Sorted(int[] array)
        {
            bool sorted = true;

            if (array.Length > 2)
            {
                for (int index = 1; index < array.Length; index++)
                {
                    if (index == array.Length - 1)
                        continue;

                    if (index == array.Length - 1)
                        continue;

                    if (!(array[index] > array[index - 1]) || !(array[index] < array[index + 1]))
                        sorted = false;
                }
            }
            else if (array.Length == 2)
                sorted = array[0] < array[1];

            return sorted;
        }

        public static int[] Push(int[] array, int number)
        {
            int[] newArry = new int[array.Length + 1];
            newArry[0] = number;

            for (int index = 0; index < array.Length; index++)
            {
                newArry[index + 1] = array[index];
            }

            return newArry;
        }

        public static int[] Append(int[] array, int number)
        {
            int[] newArray = new int[array.Length + 1];

            for (int index = 0; index < array.Length; index++)
            {
                newArray[index] = array[index];
            }

            newArray[array.Length] = number;
            return newArray;
        }
    }
}
