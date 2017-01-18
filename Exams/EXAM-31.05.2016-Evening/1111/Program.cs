using System;
using System.Collections.Generic;
using System.Numerics;


namespace Problem01_MessageS1
{
    class Program
    {
        static void Main()
        {
            string[] gorosNumbers = { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };
            string firstNumber = Console.ReadLine();
            char opperation = char.Parse(Console.ReadLine());
            string secondNumber = Console.ReadLine();
            BigInteger decTOTALfirstNum = 0;
            BigInteger decTOTALsecondNum = 0;
            for (int i = 0; i < firstNumber.Length; i += 3)
            {
                var DigitsinDec= firstNumber.Substring(i, 3);
                var decimalFirstNum = Array.IndexOf(gorosNumbers, DigitsinDec);
                decTOTALfirstNum *= 10;
                decTOTALfirstNum += decimalFirstNum;
            }
            for (int i = 0; i < secondNumber.Length; i += 3)
            {
                var DigitsinDec = secondNumber.Substring(i, 3);
                var decimalSecondNum = Array.IndexOf(gorosNumbers, DigitsinDec);
                decTOTALsecondNum *= 10;
                decTOTALsecondNum += decimalSecondNum;
            }
            BigInteger result = 0;
            if (opperation == '+')
            {
                result = decTOTALfirstNum + decTOTALsecondNum;
            }

           else
            {
                result = decTOTALfirstNum - decTOTALsecondNum;
            }
            //result = 56359;
            string output = "";
            string somestring = result.ToString();
            for (int i = 0; i < somestring.Length; i++)
            {
                output += gorosNumbers[int.Parse(somestring[i].ToString())];
            }
            Console.WriteLine(output);
        }
    }
}