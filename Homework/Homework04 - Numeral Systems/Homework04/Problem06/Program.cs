using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06
{
    class Program
    {
        static string ConvertBinaryToHexademical(string binaryNumber)
        {
            if (binaryNumber.Length % 4 != 0)
            {
                int padleft = (4*(binaryNumber.Length/4+1));
                binaryNumber = binaryNumber.PadLeft(padleft, '0');
            }
            string hexademicalNumber = "";
            for (int i = binaryNumber.Length-1; i >=3; i-=4)
            {
                string temp = Convert.ToString(binaryNumber[i-3]) + Convert.ToString(binaryNumber[i - 2]) + 
                    Convert.ToString(binaryNumber[i - 1]) + Convert.ToString(binaryNumber[i]);
                hexademicalNumber = ConvertOnePartBinaryToHexadecimal(temp) + hexademicalNumber;
            }
            return hexademicalNumber;
        }
        static string ConvertOnePartBinaryToHexadecimal(string partBinaryNumber)
        {
            int partHexadecimalNumber = 0;
            int pow = 1;
            for(int i=partBinaryNumber .Length -1;i>=0;i--)
            {
                partHexadecimalNumber += (partBinaryNumber[i] - 48) * pow;
                pow *= 2;
            }
            if (partHexadecimalNumber > 9)
            {
                string partHexadecimalNumberString = "";
                switch (partHexadecimalNumber) {
                    case 10:
                    partHexadecimalNumberString = "A";
                     break;
                    case 11:
                     partHexadecimalNumberString = "B";
                     break;
                    case 12:
                        partHexadecimalNumberString = "C";
                        break;
                    case 13:
                        partHexadecimalNumberString = "D";
                        break;
                    case 14:
                        partHexadecimalNumberString = "E";
                        break;
                    case 15:
                        partHexadecimalNumberString = "F";
                        break;
                }
                return partHexadecimalNumberString;
            }
            return Convert.ToString(partHexadecimalNumber);
        }
        static void Main()
        {
            string binaryNumber = Console.ReadLine();
            Console.WriteLine(ConvertBinaryToHexademical(binaryNumber));
        }
    }
}
