using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class Program
    {
        static double NumbersLargerThanNeighbours(double[] inputArray)
        {
            int maxCounter = 0;
            for (int i = 1; i < inputArray.Length-1; i++)
            {
                if(inputArray [i]>Math.Max(inputArray[i-1],inputArray[i+1]))
                {
                    maxCounter++;
                }
            }
            return maxCounter;
        }
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Console.WriteLine(NumbersLargerThanNeighbours(array));
        }
    }
}
