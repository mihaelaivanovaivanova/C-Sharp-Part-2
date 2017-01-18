using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_9Gag
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] GagNums = { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };
            string input = Console.ReadLine();
            string gagDigit = input[0].ToString();
            string numIn9="";
            int someIndex = 1;
            //bool containsDigit = false;
            while (input != string.Empty)
            {
                if (GagNums.Contains(gagDigit))
                {
                    var index = Array.FindIndex(GagNums, digit => digit.Contains(gagDigit));
                    numIn9 += index;
                    input = input.Remove(0, gagDigit.Length);
                    someIndex = 0;
                    gagDigit = "";
                }
                else
                {
                    gagDigit += input[someIndex];
                    someIndex++;
                }
            }
            //Console.WriteLine(numIn9);
            BigInteger numInDec = 0;
            for (int i =0; i <numIn9.Length; i++)
            {
                numInDec = numInDec * 9 + (long)(numIn9[i]-'0');
            }
            Console.WriteLine(numInDec);
        }
    }
}
