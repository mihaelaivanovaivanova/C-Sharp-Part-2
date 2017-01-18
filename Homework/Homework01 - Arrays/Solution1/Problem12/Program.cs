using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string input = Console.ReadLine().ToLower();
            foreach (var letter in input)
            {
                Console.WriteLine(Array.IndexOf(alphabet, letter));
            }
        }
    }
}
