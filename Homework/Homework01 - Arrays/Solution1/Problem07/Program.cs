using System;


namespace Problem07
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            double [] array = new double[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                double minNumber = array[i];
                int minIndex = i;
                for (int j =i; j< size;j++)
                {
                    if (array[j] < minNumber)
                    {
                        minNumber = array[j];
                        minIndex = j;
                    }
                }
                double temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(array [i]);
            }
        }
    }
}
