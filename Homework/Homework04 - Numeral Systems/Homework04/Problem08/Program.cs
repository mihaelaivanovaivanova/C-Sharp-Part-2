using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08
{
    class Program
    {
        static string ConvertDecToBin(int decNumber)
        {
            string binaryNumber = "";
           // binaryNumber = decNumber % 2 + binaryNumber;
            //decNumber /= 2;
            if(decNumber >= 0)
            {
                while (decNumber > 0)
                {
                    binaryNumber = decNumber % 2 + binaryNumber;
                    decNumber /= 2;
                }
                return binaryNumber = binaryNumber.PadLeft(16, '0');
            }
            else
            {
                decNumber += 1;
                while (Math.Abs(decNumber) > 0)
                { // or with string.Replace('1','2').Replace('0,'1').Replace('2','0');
                    if (decNumber % 2 == 0)
                    {
                        binaryNumber = "1" + binaryNumber;
                        decNumber /= 2;
                    }
                    else
                    {
                        binaryNumber = "0" + binaryNumber;
                        decNumber /= 2;
                    }
                    
                }
                
                return binaryNumber =binaryNumber.PadLeft(16, '1');
            }
        }
            
        static void Main(string[] args)
        {
            int decNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertDecToBin(decNumber));
        }
    }
}

