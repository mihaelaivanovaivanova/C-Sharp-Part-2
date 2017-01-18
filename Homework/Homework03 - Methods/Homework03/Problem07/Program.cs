using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07
{
    class Program
    {
        static string ReverseNumbers(string decimalNumber)
        {
            int lenght = decimalNumber.Length;
            string reversedNumber=null;
            for (int i = lenght -1; i >=0; i--)
            {
                reversedNumber +=decimalNumber [i];
            }
            return reversedNumber;
        }
        static void Main(string[] args)
        {
            string numberAsDecimal = Console.ReadLine();
            if(Convert.ToDecimal(numberAsDecimal)<0)
            {
                numberAsDecimal = numberAsDecimal.Remove('-');
                Console.WriteLine("-"+ReverseNumbers(numberAsDecimal));
            }
            else
            {
                Console.WriteLine(ReverseNumbers (numberAsDecimal ));
            }
           
            
        }
    }
}
