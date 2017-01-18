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
            string inputOne = Console.ReadLine().ToLower();
            string inputTwo = Console.ReadLine().ToLower();
            bool areEqual = true;
                for (int i = 0; i <Math.Min(inputOne .Length, inputTwo.Length) ; i++)
                {
                    if (inputOne[i] != inputTwo[i])
                    {
                        areEqual = false;
                        Console.WriteLine(inputOne[i] > inputTwo[i] ? ">" : "<");
                        break;
                    }
                }
                if (areEqual == true&&inputOne.Length==inputTwo.Length)
                    Console.WriteLine("=");
                else if(areEqual== true&&inputOne.Length != inputTwo.Length)
            {
                Console.WriteLine(inputOne.Length > inputTwo.Length ? ">" : "<");
            }
        }
    }
}
