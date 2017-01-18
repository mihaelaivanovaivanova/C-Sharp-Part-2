using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01___ReverseString
{
    class Program
    {
        static string ReverseString(string stringToReverse)
        {
            StringBuilder reversedString = new StringBuilder();
            for (int i = stringToReverse .Length-1; i >=0; i--)
            {
                reversedString.Append(stringToReverse[i]);
            }
            return reversedString.ToString();
        }
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            Console.WriteLine(ReverseString (inputString));
        }
    }
}
