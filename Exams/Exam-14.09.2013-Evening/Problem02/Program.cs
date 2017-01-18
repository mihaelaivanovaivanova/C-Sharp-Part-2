using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            string[] reversedWords = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                reversedWords[i] = new string (words[i].Reverse().ToArray());
                //Console.WriteLine(reversedWords[i]);
            }
            string scrambledLetters = "";
            int maxLenghtWord = 0;
            for (int i = 0; i < reversedWords.Length; i++)
            {
                if (maxLenghtWord < reversedWords[i].Length)
                {
                    maxLenghtWord = reversedWords[i].Length;
                }
            }
            for (int i = 0; i <maxLenghtWord; i++)
            {
                foreach(string word in reversedWords)
                {
                    if(i<word.Length)
                    {
                        scrambledLetters += word[i];
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            int lenght = scrambledLetters.Length;
            List<char> output =scrambledLetters.ToList();
            for (int i = 0; i < lenght; i++)
            {
                char currentLetter = output[i];
                output.RemoveAt(i);
                if (currentLetter< 'a')
                {
                    output.Insert(((currentLetter - 'A'+1+i) % scrambledLetters.Length), currentLetter);
                }
                else
                {
                    output.Insert(((currentLetter- 'a' + 1+i) % scrambledLetters.Length), currentLetter);
                }
            }
            for(int i = 0; i < output.Count; i++)
            {
                Console.Write(output[i]);
            }
            Console.WriteLine();
        }
    }
}
