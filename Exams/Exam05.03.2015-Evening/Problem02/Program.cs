using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            long [] sequence = Console.ReadLine().Split(' ').Select (long.Parse).ToArray();
            long sumEvenDifference = 0;
            for (int i = 1; i < sequence.Length; i++)//see end limit
            {
                long absoluteDifference = Math.Max((sequence[i]), sequence[i - 1]) - Math.Min((sequence[i]), sequence[i - 1]);
                if (absoluteDifference % 2 == 0)
                {
                    sumEvenDifference += absoluteDifference;
                    i++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(sumEvenDifference);
        }
    }
}
