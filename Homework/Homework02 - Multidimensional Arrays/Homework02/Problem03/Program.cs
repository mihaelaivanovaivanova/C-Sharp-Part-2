using System;

namespace Problem03
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
            int counter = 1;
            int maxCounter = 1;
            //Search in rows
            for (int i = 0; i < n; i++)
            { 
                for (int j = 0; j < m-1; j++)
                {
                    if(matrix[i, j] == matrix[i, j + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                    }
                }
                counter = 1;
            }
            // Search in columns
            for (int i = 0; i < m ; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    if (matrix[j, i] == matrix[j+1, i])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                   if (counter > maxCounter)
                    {
                        maxCounter = counter;
                    }
                }
                counter = 1;
            }
            //Search in diagonal 1
            if (n >= m)
            { 
            int lenght = Math.Min(m, n);
            for (int i = 0; i <= m-2 ; i++)
            {
                    for(int j=0;j<m-2;j++)
              
                    if(matrix[i,j]==matrix[i+1,j+1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                    }
                }
                counter = 1;
            }
            for (int i = 0; i < m - 2; i++)
            {
                for (int j = 0; i < Math.Max(m, n) - i - 2; j++)
                {
                    if (matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                    }
                }
                counter = 1;
            }
                       
                //Search in diagonal 2
                for (int i = 0; i < lenght - 2; i++)
            {
                for (int j = m-1; j >m-lenght-2; j--)
                {
                    if (matrix[i, j] == matrix[i + 1, j -1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                    }
                }
                counter = 1;
            }

            Console.WriteLine(maxCounter);
        }
    }
}
