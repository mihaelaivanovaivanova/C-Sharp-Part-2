using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Program
    {
        static string ConvertDecimaltoHexadecimal(long decimalNumber)
        {
            string hexadecimalNumber = "";
            while(decimalNumber >0)
            {
                
                if(decimalNumber%16<10)
                {
                    hexadecimalNumber = decimalNumber%16+ hexadecimalNumber;
                }
                else
                {
                    switch(decimalNumber % 16)
                    {
                        case 10:
                    hexadecimalNumber = "A" + hexadecimalNumber;
                            break;
                        case 11:
                            hexadecimalNumber = "B" + hexadecimalNumber;
                            break;
                        case 12:
                            hexadecimalNumber = "C" + hexadecimalNumber;
                            break;
                        case 13:
                            hexadecimalNumber = "D" + hexadecimalNumber;
                            break;
                        case 14:
                            hexadecimalNumber = "E" + hexadecimalNumber;
                            break;
                        case 15:
                            hexadecimalNumber = "F" + hexadecimalNumber;
                            break;
                    }
                }
                decimalNumber /= 16;
            }
            return hexadecimalNumber;
        }
        static void Main(string[] args)
        {
            long decimalNumber = long.Parse(Console.ReadLine());
            Console.WriteLine(ConvertDecimaltoHexadecimal(decimalNumber));
        }
    }
}
