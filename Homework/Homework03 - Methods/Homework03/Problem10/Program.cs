using System;
using System.Numerics;

namespace _10_N_Factorial
{
    class NFactorial
    {
        static void Main()
        {
           
            int numberN = int.Parse(Console.ReadLine());

            int[] Number = new int[1] { 1 };  

            for (int curMultiplier = 1; curMultiplier <= numberN;curMultiplier++)
            {
                Number = Multiply(Number, curMultiplier);
            }
            string toPrint = ArrayToString(Number);
            Console.WriteLine(toPrint);
        }

        // Multiply 
        public static int[] Multiply(int[] Number, int Multiplier)
        {
            BigInteger curResult = 0;
            BigInteger carryOver = 0;

            for (int curDigit = 0;curDigit < Number.Length;curDigit++)                     
            {
                curResult = Number[curDigit] *Multiplier +carryOver;
                Number[curDigit] = (int)(curResult % 10); 
                carryOver = curResult / 10;  
            }

            if (carryOver > 0)
            {
                // helper
                int oldNumberSize = Number.Length;

                // Step 1: resize the Array to accomodate the 
                // extra digits 
                Array.Resize(ref Number,
                Number.Length + carryOver.ToString().Length);
                int CarryOverLength = carryOver.ToString().Length;

                //Step 2: Append
                for (int curDigit = 0; curDigit < CarryOverLength; curDigit++)
                {
                    Number[oldNumberSize + curDigit] = (int)(carryOver % 10);

                    carryOver /= 10;
                }
            }

            // results stored in the same 
            // array
            return Number;
        }

        // Get String to Print
        public static string ArrayToString(int[] Number)
        {
            string toPrint = "";

            for (int curDigit = Number.Length - 1;curDigit >= 0;curDigit--)
            {
                toPrint += Number[curDigit].ToString();
            }
            return toPrint;
        }
    }
}