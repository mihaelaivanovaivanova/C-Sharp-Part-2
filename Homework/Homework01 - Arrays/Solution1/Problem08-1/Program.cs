using System;

class FindMaxSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] inputArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            inputArray[i] = int.Parse(Console.ReadLine());
        }
        int maxSum = 0;
        int cumulativeSum = 0;
        for (int j = 0; j < n; j++)
        {
            int arrayItem = inputArray[j];
            cumulativeSum += arrayItem;
            if (cumulativeSum > maxSum)
            {
                maxSum = cumulativeSum;
            }
            else
                if (cumulativeSum < 0)
            {
                cumulativeSum = 0;
            }
        }
        Console.WriteLine(maxSum);
    }
}