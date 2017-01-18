using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            Array.Reverse(array);
            double maxSum = 0;
            for (int i = 0; i <k; i++)
            {
                maxSum += array[i];
            }
            Console.WriteLine(maxSum );
        }
    }
}
