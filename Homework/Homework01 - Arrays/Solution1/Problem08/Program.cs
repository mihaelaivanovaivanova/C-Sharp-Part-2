using System;


namespace Problem08
{
    class Program
    {
        private static int GetMaxSum(int[] arr)
        {
            var maxSum = int.MinValue;
            var currSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                currSum += arr[i];

                if (currSum > maxSum)
                {
                    maxSum = currSum;
                }

                if (currSum < 0)
                {
                    currSum = 0;
                }
            }

            return maxSum;
        }
    }
}
