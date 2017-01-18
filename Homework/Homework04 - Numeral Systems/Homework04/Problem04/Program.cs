using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem04
{
    class Program
    {
        static BigInteger ConvertHexademicalToDecimal(string hexademicalNumber)
        {
            long pow = 1;
            BigInteger decimalNumber = 0;
            for (int i = hexademicalNumber .Length-1 ; i >=0 ; i--)
            {
                if(hexademicalNumber[i]-48<=9)
                {
                    decimalNumber += pow * (hexademicalNumber[i] - 48);
                    pow *= 16;
                }
                else
                {
                    decimalNumber += pow * (hexademicalNumber[i] - 55);
                    pow *= 16;
                }
            }
            return decimalNumber;
        }
        static void Main(string[] args)
        {
            string hexademicalNumber = Console.ReadLine();
            Console.WriteLine(ConvertHexademicalToDecimal (hexademicalNumber));

        }
    }
}
