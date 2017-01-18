using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05_ParseTags2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputText = Console.ReadLine().Split( new char[]{ '<','>'});
            string openTag = "upcase";
            string closeTag = "/upcase";
            StringBuilder modifiedText = new StringBuilder();
            for (int i = 0; i < inputText .Length-1; i++)
            {
                if (inputText[i] != openTag&& inputText[i] != closeTag)
                {
                    modifiedText.Append(inputText[i]);
                }
                else if (inputText [i]==openTag)
                {
                    modifiedText.Append(inputText[i + 1].ToUpper());
                    i++;
                }
                else 
                {
                    modifiedText.Append(inputText[i + 1]);
                    i++;
                }
            }
            Console.WriteLine(modifiedText);

        }
    }
}
