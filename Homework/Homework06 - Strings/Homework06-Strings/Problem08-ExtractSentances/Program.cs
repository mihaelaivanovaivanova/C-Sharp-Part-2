using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08_ExtractSentances
{
    class Program
    {
        static void Main(string[] args)
        {
            string extractWord = Console.ReadLine().ToLower();
            string[] text = Console.ReadLine().Split(new char[] { '.', '?', '!' });
            string extractWordOption1 = " " + extractWord+" ";
            string extractWordOption2 =" "+ extractWord+".";
            string extractWordOption4 = " " + extractWord + "?";
            string extractWordOption5 = " " + extractWord + "!";

            string extractWordOption3 =extractWord + " ";
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i]+".").ToLower().IndexOf(extractWordOption1) > -1 || 
                    (text[i]+".").ToLower ().IndexOf(extractWordOption2) > -1||
                    (text[i] + ".").ToLower ().IndexOf(extractWordOption3) > -1 ||
                    (text[i] + "?").ToLower ().IndexOf(extractWordOption4) > -1 ||
                    (text[i] + "!").ToLower().IndexOf(extractWordOption5) > -1 )
                {
                    if((text[i] + "?").IndexOf(extractWordOption4) > -1)
                    output.Append(text[i]+"?");
                    else if ((text[i] + "!").IndexOf(extractWordOption5) > -1)
                    output.Append(text[i] + "!");
                    else
                    output.Append(text[i] + ".");
                }
            }
            Console.WriteLine(output);
        }
    }
}
