using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05
{
    class Program
    {
        static string ConvertHexademicalToBinary(string hexademicalNumber)
        {
            string binaryNumber ="";
            string tempBinaryNumber ="";

            for (int i = hexademicalNumber .Length -1; i >= 0; i--)
            {
                if(hexademicalNumber[i] - 48 <= 9)
                {
                    int decimalTempNumber = hexademicalNumber[i] - 48;
                    tempBinaryNumber = (ConvertDecimalToBinary(decimalTempNumber));
                        tempBinaryNumber = tempBinaryNumber.PadLeft(4, '0');
                    binaryNumber = tempBinaryNumber + binaryNumber;
                }
                else
                {
                    int decimalTempNumber = hexademicalNumber[i] - 55;
                    tempBinaryNumber = (ConvertDecimalToBinary(decimalTempNumber));
                        tempBinaryNumber = tempBinaryNumber.PadLeft(4, '0');
                    binaryNumber = tempBinaryNumber + binaryNumber;
                }
            }
            binaryNumber = binaryNumber.TrimStart('0');
            return binaryNumber;
        }
        static string ConvertDecimalToBinary(int decimalNumber)
        {
            string binaryNumber = "";
            while(decimalNumber>0)
            {
                binaryNumber = decimalNumber % 2+binaryNumber;
                decimalNumber /= 2;
            }
            return (binaryNumber);
        }
        static void Main(string[] args)
        {
            string hexademicalNumber = Console.ReadLine();
            Console.WriteLine(ConvertHexademicalToBinary(hexademicalNumber));
        }
    }
}
