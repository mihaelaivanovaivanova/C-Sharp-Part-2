using System;
using System.Collections.Generic;
using System.Numerics;


namespace Problem01_MessageS1
{
    class Program
    {
        static void Main()
        {
            string[] gorosNumbers ={ "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };
            string firstNumber = Console.ReadLine();
            char opperation = char.Parse(Console.ReadLine());
            string secondNumber = Console.ReadLine();
            string[] splittedFirstNumber = new string[firstNumber.Length / 3];
            string[] splittedSecondNumber = new string[secondNumber.Length / 3];
            
            for (int i = 0, j=0; i < firstNumber.Length; i+=3,j++)
            {
                splittedFirstNumber[j] = firstNumber.Substring(i, 3);
            }
            for (int i = 0,j=0; i < secondNumber.Length; i+=3,j++)
            {
                splittedSecondNumber[j] = secondNumber.Substring(i, 3);
            }
            string firstNumInDec = "";
            string secondNumInDec = "";
            BigInteger result = 0;
            for (int i = 0; i < splittedFirstNumber.Length; i++)
            {
                firstNumInDec += Array.IndexOf(gorosNumbers, splittedFirstNumber[i]);
            }
            for (int i = 0; i < splittedSecondNumber.Length; i++)
            {
                secondNumInDec += Array.IndexOf(gorosNumbers, splittedSecondNumber[i]);
            }
            if (opperation == '+')
            {
                result = BigInteger.Parse(firstNumInDec) + BigInteger.Parse(secondNumInDec);
            }
            if (opperation == '-')
            {
                result = BigInteger.Parse(firstNumInDec) - BigInteger.Parse(secondNumInDec);
            }
            string output = "";
            BigInteger shitResult = result;
            for (int i = 0; i < result.ToString().Length; i++)
            {
                output = gorosNumbers[(int)(shitResult % 10)] + output;
                shitResult /= 10;
            }
            Console.WriteLine(output);
        }
    }
}