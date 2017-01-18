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
            //input of the matrix
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }
            long maxsum = long.MinValue;
            long sum = long.MinValue;
            for (int i = 0; i < n-2; i++)
            {
                for (int j = 0; j < n-4; j++)
                {
                    if((matrix [i,j]+1==matrix[i,j+1])&&
                       (matrix[i, j] + 2 == matrix[i, j + 2])&&
                       (matrix[i, j] + 3 == matrix[i+1, j + 2])&&
                       (matrix[i, j] + 4 == matrix[i + 2, j + 2])&&
                       (matrix[i, j] + 5 == matrix[i + 2, j + 3])&&
                       (matrix[i, j] + 6 == matrix[i + 2, j + 4]))
                    {
                        sum =7L* matrix[i, j] + 21; //1+2+3+...+6=21;
                        if(maxsum<sum)
                        {
                            maxsum = sum;
                        }
                    }
                }
            }
            Console.WriteLine("YES {0}",maxsum);

        }
    }
}
