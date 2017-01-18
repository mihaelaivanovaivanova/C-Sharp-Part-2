using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Problem14
{
    class Program
    {
        static double GetMinimum(double[] someArray)
        {
            double minimumValue = double.MaxValue;
            for (int i = 0; i < someArray .Length ; i++)
            {
                minimumValue = Math.Min(someArray[i], minimumValue);
            }
            return minimumValue;
        }
        static double GetMaximum(double[] someArray)
        {
            double maximumValue = double.MinValue ;
            for (int i = 0; i < someArray.Length; i++)
            {
                maximumValue = Math.Max(someArray[i], maximumValue);
            }
            return maximumValue;
        }
        static double Average(double[] someArray)
        {
            double sumOfNumbers =0;
            for (int i = 0; i < someArray.Length; i++)
            {
                sumOfNumbers +=someArray [i];
            }
            return (sumOfNumbers /(double)someArray .Length);
        }
        static double Sum(double[] someArray)
        {
            double sumOfNumbers = 0;
            for (int i = 0; i < someArray.Length; i++)
            {
                sumOfNumbers += someArray[i];
            }
            return (sumOfNumbers);
        }
        static BigInteger Product(double[] someArray)
        {
             BigInteger productOfNumbers = 1;
            for (int i = 0; i < someArray.Length; i++)
            {
                productOfNumbers *= (int)someArray[i];
            }
            return ((BigInteger)productOfNumbers);
        }
        static void Main(string[] args)
        {
            double[] inputNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Console.WriteLine(GetMinimum (inputNumbers ));
            Console.WriteLine(GetMaximum(inputNumbers));
            Console.WriteLine("{0:F2}", Average(inputNumbers));
            Console.WriteLine(Sum(inputNumbers));
            Console.WriteLine((BigInteger)Product(inputNumbers ));

        }
    }
}
