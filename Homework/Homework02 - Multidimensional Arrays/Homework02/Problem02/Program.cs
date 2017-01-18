using System;
namespace Problem02
{
    class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int n = int.Parse(numbers[0]);
            int m = int.Parse(numbers[1]);
            double[,] matrix = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = double.Parse(line[j]);
                }
            }
            double bestSum = double.MinValue;
            double sum = 0;
            for(int i=0; i < n - 2; i++)
            {
                for(int j=0;j<m-2; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                        matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i+1 , j + 2] +
                        matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if(sum>=bestSum)
                    {
                        bestSum = sum;
                        sum=0;
                    }
                    else
                    {
                        sum = 0;
                    }
                }
            }
            Console.WriteLine(bestSum);
        }
    }
}
