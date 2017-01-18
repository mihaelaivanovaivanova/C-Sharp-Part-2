using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem07
{
    class Program
    {
        static long ConvertFromSToDecimal(string NumberInS, int baseS)
        {
            long numberNInDecimal = 0;
            long pow = 1;
            for (int i = NumberInS.Length - 1; i >= 0; i--)
            {
                if (NumberInS[i] - 48 < 10)
                {
                    numberNInDecimal += (NumberInS[i] - 48) * pow;
                    pow *= baseS;
                }
                else
                {
                    numberNInDecimal += (NumberInS[i] - 55) * pow;
                    pow *= baseS;
                }
                
            }
            return numberNInDecimal;
        }
        static string ConvertFromDecimalToD(long decimalNumber, int baseD)
        {
            string numberInD = "";
            while (decimalNumber > 0)
            {
                if (decimalNumber % baseD < 10)
                {
                    numberInD = decimalNumber % baseD + numberInD;
                    decimalNumber /= baseD;
                }
                else
                {
                    switch ((long)decimalNumber % baseD)
                    {
                        case 10:
                            numberInD = "A" + numberInD;
                            break;
                        case 11:
                            numberInD = "B" + numberInD;
                            break;
                        case 12:
                            numberInD = "C" + numberInD;
                            break;
                        case 13:
                            numberInD = "D" + numberInD;
                            break;
                        case 14:
                            numberInD = "E" + numberInD;
                            break;
                        case 15:
                            numberInD = "F" + numberInD;
                            break;
                    }
                    decimalNumber /= baseD;
                }

            }
            return numberInD;
        }
        static string NumberNInBaseD(string numberInS, int baseS, int baseD)
        {
            long nInDecimal = ConvertFromSToDecimal(numberInS, baseS);
            string NumberNInBaseD = ConvertFromDecimalToD(nInDecimal, baseD);
            return NumberNInBaseD;
        }
        static void Main(string[] args)
        {
            int baseS = int.Parse(Console.ReadLine());
            string numberNInBaseS = Console.ReadLine();
            int baseD = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberNInBaseD(numberNInBaseS, baseS, baseD));
        }
    }
}
