using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10_UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string input = Console.ReadLine();
            int c = 0;
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                c = input[i];
                output.Append("\\u");
                output.Append(c.ToString("X4"));
            }
            Console.WriteLine(output);
        }
    }
}
