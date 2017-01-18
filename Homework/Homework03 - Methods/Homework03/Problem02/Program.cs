using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        static int GetMax(int firstNumber, int secondNumber)
        {
            int biggerNumber = (firstNumber>secondNumber ? firstNumber:secondNumber );
            return biggerNumber;
        }
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray ();
            Console.WriteLine(GetMax (numbers [0], GetMax (numbers [1],numbers [2])));
        }
    }
}
