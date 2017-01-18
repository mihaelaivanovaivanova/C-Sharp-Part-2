using System;


namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int index = 0; index < n; index++)
            {
                array[index] = index * 5;
                Console.WriteLine(array [index]);
            }
        }
    }
}
