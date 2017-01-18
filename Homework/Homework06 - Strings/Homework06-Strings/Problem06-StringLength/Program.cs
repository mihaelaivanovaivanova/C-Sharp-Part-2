using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06_StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            inputString = inputString.Replace(@"\", "");
            Console.WriteLine(inputString.PadRight(20,'*'));
        }
    }
}
