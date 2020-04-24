using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithims.Algorithims
{
    public static class BinarySearch
    {
        public static int ArrayBinarySearch(int[] array, int searchNumber) 
        { 
            int centerIndex = array.Length / 2;
            int numberGuess = array[centerIndex];

            if (searchNumber == numberGuess)
                return numberGuess;
            else if (searchNumber > numberGuess)
                return ArrayBinarySearch(CreateNewArraryHalf(centerIndex, array, isLessThan: false, isDivisbleByTwo: array.Length % 2 == 0), searchNumber);
            else
                return ArrayBinarySearch(CreateNewArraryHalf(centerIndex, array, isLessThan: true, isDivisbleByTwo: array.Length % 2 == 0), searchNumber);

            int[] CreateNewArraryHalf(int length, int[] oldArray, bool isLessThan, bool isDivisbleByTwo)
            {
                int[] newArrayHalf = isDivisbleByTwo ? new int[length]: new int[length + 1];

                if (isDivisbleByTwo) 
                {
                    if (isLessThan)
                        Array.Copy(oldArray, 0, newArrayHalf, 0, length);
                    else
                        Array.Copy(oldArray, length, newArrayHalf, 0, length);                
                }
                else
                {
                    if (isLessThan)
                        Array.Copy(oldArray, 0, newArrayHalf, 0, length + 1);
                    else
                        Array.Copy(oldArray, length, newArrayHalf, 0, length + 1);
                }

                return newArrayHalf;
            }
        }
    }
}
