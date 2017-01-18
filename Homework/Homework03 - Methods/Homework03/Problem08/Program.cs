using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08
{
    class Program
    {
        static string SumOfArrays(byte[] array1, byte[] array2)
        {
            int pendingNum = 0;
            byte[] arraySum = new byte[Math.Max(array1.Length, array2.Length)];
            for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
            {
                {
                    if (pendingNum == 1 && (array1[i] + array2[i]) >= 9)
                    {
                        arraySum[i] = (byte)((array1[i] + array2[i] + 1) % 10);
                        pendingNum = 1;
                    }
                    else if (pendingNum == 1 && array1[i] + array2[i] < 9)
                    {
                        arraySum[i] = (byte)(array1[i] + array2[i] + 1);
                        pendingNum = 0;
                    }
                    else if (pendingNum == 0 && array1[i] + array2[i] <= 9)
                    {
                        arraySum[i] = (byte)(array1[i] + array2[i]);
                        pendingNum = 0;
                    }
                    else if (pendingNum == 0 && array1[i] + array2[i] > 9)
                    {
                        arraySum[i] = (byte)((array1[i] + array2[i]) % 10);
                        pendingNum = 1;
                    }
                }
            }
            for (int i = Math.Min(array1.Length, array2.Length); i < Math.Max(array1.Length, array2.Length); i++)
            {
                if (array1.Length > array2.Length)
                { if (pendingNum == 1)
                    {
                        arraySum[i] = (byte)(array1[i] + 1);
                        pendingNum = 0;
                    }
                    else
                    {
                        arraySum[i] = array1[i];
                    }
                }
                else
                {
                    if (pendingNum == 1)
                    {
                        arraySum[i] = (byte)(array2[i] + 1);
                        pendingNum = 0;
                    }
                    else
                    {
                        arraySum[i] = array2[i];
                    }
                }
            }
            string result = string.Join(" ", arraySum);
            return result;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sizeOne = Convert.ToInt32(input.Split(' ')[0]);
            int sizeTwo = Convert.ToInt32(input.Split(' ')[1]);
            byte[] arrayOne = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();
            byte[] arrayTwo = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();
            Console.WriteLine(SumOfArrays(arrayOne, arrayTwo));
        }
    }
}
