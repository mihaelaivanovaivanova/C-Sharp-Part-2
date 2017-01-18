using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_SpecialValues
{
    class Program
    {
        static int[][] ReadData(int[][] juggedArray)
        {
            for (int i = 0; i < juggedArray.GetLength(0); i++)
            {
                int[] currentLine = Console.ReadLine()
                                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select (int.Parse)
                                    .ToArray();
                juggedArray[i] = new int[currentLine.Length];
                for (int j = 0; j < currentLine.Length; j++)
                {
                    juggedArray[i][j] = currentLine[j];
                } 
            }
            return juggedArray;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[][] numbers = new int[N][];
            ReadData(numbers);
            for (int i = 0; i < numbers[0].GetLength(0); i++)
            {

            }
        }
    }
}
