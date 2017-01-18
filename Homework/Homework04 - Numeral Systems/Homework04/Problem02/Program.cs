using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        static long ConvertBinaryToDec(string binaryNumber)
        {
            long decimalNumber = 0;
            long pow = 1;
            for (int i = binaryNumber.Length-1; i >=0; i--)
            {
                decimalNumber += pow * (binaryNumber[i]-48);
                pow *= 2;
            }
            return decimalNumber;
        }
        static void Main(string[] args)
        {
            string binaryNumber = Console.ReadLine();
            Console.WriteLine(ConvertBinaryToDec(binaryNumber));
                
        }
    }
}
