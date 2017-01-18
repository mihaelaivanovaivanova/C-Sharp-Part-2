using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            double[] array = new double[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            int count = 1;
            int maxCount = 1;
            //List<int> maxSequence = new List<int>();
            for (int i = 0; i < size-1; i++)
            {
                if(array[i]==array[i + 1])
                {
                    count++;
                    maxCount = Math.Max(maxCount, count);
                   // maxSequence.Add(array[i]);
                    //if (i==size-2)
                    //{
                    //    maxSequence.Add(array[i + 1]);
                    //}
                }
                else
                {
                    count = 1;
                   // maxSequence.Clear();
                }
            }
            Console.WriteLine(maxCount);
            //int sizeOfList = maxSequence.Count;
            //for (int i = 0; i <maxSequence .Count  ; i++)
            //{
            //   Console.WriteLine(maxSequence [i]);
            //}
        }
    }
}
