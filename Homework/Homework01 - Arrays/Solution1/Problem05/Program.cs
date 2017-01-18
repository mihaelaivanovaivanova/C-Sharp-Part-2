using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
           // List<int> maxSequence = new List <int>();
            int maxCount = 1;
            int count = 1;
            for (int i = 0; i <size-1; i++)
            {
                if (array[i]<=array [i+1])
                {
                    count++;
                    maxCount = Math.Max(maxCount, count);
                    //if (maxCount <count)
                    //{
                    //    maxCount = count;
                    //    //maxSequence.Add(array[i]);
                    //}
                }
                else
                {
                    count = 1;
                   // maxSequence.Clear();
                }
            }
            Console.WriteLine(maxCount );
        }
    }
}
