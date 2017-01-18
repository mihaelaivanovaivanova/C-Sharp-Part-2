using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem23_SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char previousLetter = input[0];
            StringBuilder output = new StringBuilder();
            output.Append(input[0]);
            for (int i = 1; i <input.Length; i++)
            {
                if (input[i] == previousLetter)
                {
                    continue;
                }
                else
                {
                    output.Append(input[i]);
                    previousLetter = input[i];
                }
            }
            Console.WriteLine(output);
        }
    }
}
