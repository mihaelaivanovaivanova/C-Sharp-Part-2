using System;
                using System.Collections.Generic;
                using System.Linq;
                using System.Text;
                using System.Threading.Tasks;
                using System.Globalization;
                using System.Threading;

namespace _05_Parse_Tags_2
    {
        class ParseTags2
        {
        static string ModifyString(string text)
        {
            string openTag = "<upcase>";
            string closeTag = "</upcase>";
            var openTagIndex = text.IndexOf(openTag);
            var closeTagIndex = text.IndexOf(closeTag);

            while (openTagIndex >-1)
            {
                text = text.Replace(text.Substring(openTagIndex,closeTagIndex - openTagIndex),
                     text.Substring(openTagIndex,closeTagIndex - openTagIndex).ToUpper());


                text = text.Remove(closeTagIndex, closeTag.Length);
                text = text.Remove(openTagIndex, openTag.Length);

                openTagIndex = text.IndexOf(openTag, ++openTagIndex);
                try
                {
                    closeTagIndex = text.IndexOf(closeTag, ++closeTagIndex);
                }
                catch (ArgumentOutOfRangeException)
                {
                    closeTagIndex = -1;
                }
            }
            return text;
        }

            static void Main()
            {
                string text = Console.ReadLine();
            Console.WriteLine(ModifyString(text));
            }
        }
    }

 