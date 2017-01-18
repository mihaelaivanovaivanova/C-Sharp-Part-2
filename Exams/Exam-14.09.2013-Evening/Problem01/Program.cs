using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alphabet =
            {
                "Rawr","Rrrr","Hsst","Ssst","Grrr","Rarr","Mrrr","Psst","Uaah","Uaha","Zzzz","Bauu","Djav","Myau","Gruh"
            };
            string input = Console.ReadLine();
            string[] splittedInput = new string[input.Length / 4];
            for (int i = 0; i < splittedInput.Length; i++)
            {
                splittedInput[i] = input.Substring(i * 4, 4);
                //Console.WriteLine(splittedInput [i]);
            }
            long[] convertedTo15SystemArray = new long[splittedInput.Length];
            long decimalNumber = 0;
            for (int i = 0; i < splittedInput.Length; i++)
            {
                convertedTo15SystemArray[i] = Array.IndexOf(alphabet, splittedInput[i]);
                decimalNumber += convertedTo15SystemArray[i] * (long)Math.Pow(15, (splittedInput.Length - i-1));
            }
            Console.WriteLine(decimalNumber);


        }
    }
}
