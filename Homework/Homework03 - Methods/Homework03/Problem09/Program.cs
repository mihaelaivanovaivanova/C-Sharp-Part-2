using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem09
{
    class Program
    {
        static double GetMaxIndex(double[] someArray, int start, int end)
        {

            int maxIndex = 0;
            double maxNumber = double.MinValue;
            for (int j = start; j < end; j++)
            {
                if (someArray[j] > maxNumber)
                {
                    maxNumber = someArray[j];
                    maxIndex = j;
                }
            }
            return maxIndex;
        }
        static void SwapNumbers(double[] someArray,int start,double currentNumber,int currentIndex)
        {
            double IndexOfMaxValue = GetMaxIndex(someArray, start, someArray.Length);
            double temp = someArray [(int)IndexOfMaxValue];
            someArray[(int)IndexOfMaxValue] = currentNumber;
            someArray [currentIndex] = temp;
        }
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            double[] arrayToSort = Console.ReadLine().Trim(' ').Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < size; i++)
            {
                SwapNumbers(arrayToSort,i,arrayToSort[i],i);
            }
            Array.Reverse(arrayToSort);
            for (int i = 0; i < size; i++)
            {
                if (i != size - 1)
                    Console.Write(arrayToSort[i] + " ");
                else
                    Console.Write(arrayToSort[i]);
            }

        }
    }
}