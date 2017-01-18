using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_GreedyDworf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = Console.ReadLine()
                           .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();
            int numberOfPatterns = int.Parse(Console.ReadLine());
            // int[][] Patterns =new int  [numberOfPatterns][];
            long collectedSum = 0;
            long maxCollectedSum = 0;
            //see jagged arrays
            for (int i = 0; i < numberOfPatterns; i++)
            {
                int[] coinsToModify = coins;
                int[] currentPattern = Console.ReadLine()
                           .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();
                int valleyIndex = currentPattern[0];
                for (int j = 1; j < currentPattern.Length; j++)
                {
                    while (coinsToModify[valleyIndex] != 0)
                    {
                        collectedSum += coinsToModify[valleyIndex];
                        valleyIndex += currentPattern[j];
                        coinsToModify[valleyIndex] = 0;
                    }
                }
                if (maxCollectedSum < collectedSum)
                {
                    maxCollectedSum = collectedSum;
                }
            }
            Console.WriteLine(maxCollectedSum);
        }
    }
}
