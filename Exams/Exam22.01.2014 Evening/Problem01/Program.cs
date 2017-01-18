using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alphabet =
            {
                "LON+",
                "VK-",
                "*ACAD",
                "^MIM"  ,
                "ERIK|"  ,
                "SEY&"  ,
                "EMY>>"   ,
                "/TEL"   ,
                "<<DON"
            };
            ulong number = ulong.Parse(Console.ReadLine());
            int[] digits = new int[32];
            int digitCount = 0;
            // convert to 9 system;
            do // za da vleze i 0 kato input
            {
                digits[digitCount] = (int)(number % 9);
                number /= 9;
                digitCount++;
            }
            while (number > 0);
            for (int i = digitCount -1; i >=0 ; i--)
            {
                Console.Write(alphabet[digits[i]]);
            }
            Console.WriteLine();
        }
    }
}
