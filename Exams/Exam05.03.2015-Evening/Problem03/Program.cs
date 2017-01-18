using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fieldSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = fieldSize[0];
            int cols = fieldSize[1];
            int startValue = 0;
            int[,] matrix = new int[rows, cols];
            for (int i = rows-1 ; i >=0; i--)
            {
                for (int j = 0; j < cols-1; j++)
                {
                    matrix[i, j] = (rows - 1 - i) * 3 + j * 3;
                }
            }
        }
    }
}
