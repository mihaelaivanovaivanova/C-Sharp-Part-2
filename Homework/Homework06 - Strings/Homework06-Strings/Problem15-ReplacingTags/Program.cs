using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem15_ReplacingTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string openTagHref = "<a href=";
            string closeTagHref = @"</a";
            string openTagHref1 = "a href=";
            string closeTagHref2 = @"/a";
            String openTagtoReplace = "[URL=";
            String closeTagtoReplace = "(/URL)";
            StringBuilder output = new StringBuilder();
            string pattern = "(>|<)";
            string[] brokenText = Regex.Split(input,pattern);
            for (int i = 1; i < brokenText.Length; i++)
            {
                Console.WriteLine(brokenText[i]);

                if((brokenText[i-1]+brokenText[i]).IndexOf(openTagHref) > -1)
                {
                    brokenText[i + 1] = string.Empty;
                    brokenText[i - 1] = string.Empty;
                    //brokenText[i]=brokenText[i].Replace(openTagHref, openTagtoReplace); 
                }
                if ((brokenText[i - 1] + brokenText[i]).IndexOf(closeTagHref) > -1)
                {
                    brokenText[i + 1] = string.Empty;
                    brokenText[i - 1] = string.Empty;
                   // brokenText[i] = brokenText[i].Replace(closeTagHref, closeTagtoReplace);
                }
            }
            for (int i = 0; i < brokenText.Length; i++)
            {
                if (brokenText[i].IndexOf(openTagHref1) > -1)
                {
                    output.Append(brokenText[i].Replace(openTagHref1, openTagtoReplace));
                }
                if (brokenText[i].IndexOf(closeTagHref2) > -1)
                {
                    output.Append(brokenText[i].Replace(closeTagHref2, closeTagtoReplace));
                }
                else 
                {
                    output.Append(brokenText[i]);
                }
            }
           Console.WriteLine(output);
        }
    }
}
