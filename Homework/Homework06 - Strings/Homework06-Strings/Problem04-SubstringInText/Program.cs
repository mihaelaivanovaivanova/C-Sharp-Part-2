using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_SubstringInText
{
    class Program
    {
        static int FindPetternInText(string pattern, string text)
        {
            int counter = 0;
            int indexOfStartPattern = text.IndexOf(pattern);
            while(indexOfStartPattern>0)
            { 
                    indexOfStartPattern = text.IndexOf(pattern, indexOfStartPattern+1);
                    counter++;
            }
            return counter++;
        }
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower ();
            Console.WriteLine(FindPetternInText (pattern , text));
        }
    }
}
