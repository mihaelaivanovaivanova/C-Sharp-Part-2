using System;


namespace Problem10
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            double sum = double.Parse(Console.ReadLine());
            double[] array = new double[size];
            double currentSum = 0;
            int variation = 0;
            for (int i = 0; i < size; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < size-variation; i++)
            {
                for (int j= i;j<=i+variation; j++)
                {
                    currentSum += array[j];
                    if (currentSum ==sum)
                    {
                        for (int k = j-variation+1; k <= j ; k++)
                        {
                            Console.WriteLine(array[k]);
                        }
                    }
                }
                variation++;
                currentSum = 0;
            }
        }
    }
}
