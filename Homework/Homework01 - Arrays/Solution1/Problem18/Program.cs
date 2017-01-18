using System;

class RemoveElementsFromArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        //Input
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] lengths = new int[n];

        for (int i = 0; i < n; i++)
        {
            lengths[i] = 1;
        }

        int max = 1;
        for (int i = 1; i < n; i++)
        {
            for (int k = 0; k < i; k++)
            {
                if (array[i] >= array[k] && lengths[i] <= lengths[k] + 1)
                {
                    lengths[i] = lengths[k] + 1;

                    if (max < lengths[i])
                    {
                        max = lengths[i];
                    }
                }
            }
        }

        Console.WriteLine(n - max);
    }
}