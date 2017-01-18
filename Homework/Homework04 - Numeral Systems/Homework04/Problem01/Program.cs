using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Program
    {
        static string ConvertDecToBin(long decNumber)
        {
            string binaryNumber="";
            while(decNumber>0)
            {
                binaryNumber = decNumber % 2 + binaryNumber;
                decNumber /= 2;
            }
            return binaryNumber;
        }
        static void Main(string[] args)
        {
            long decNumber=long.Parse(Console.ReadLine());
            Console.WriteLine(ConvertDecToBin(decNumber));
        }
    }
}
