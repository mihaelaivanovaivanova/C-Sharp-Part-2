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
                "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w"
            };
            string[] input = Console.ReadLine().Split(' ');
            int[] num = new int[input.Length];
            int sum = 0;
            int sumIn23 = 0;
            string temp="";
            for (int i = 0; i < input.Length; i++)
            {
                int pow = input[i].Length - 1;
                foreach (char ch in input[i])
                {
                    num[i] += (ch - 97) + num[i]*23;
                    pow--;
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            sumIn23 = sum;
            while (sumIn23 > 0)
            {
                temp =alphabet[sumIn23 % 23]+temp;
                sumIn23 /= 23;
            }
            Console.WriteLine("{0} = {1}",temp,sum);
        }
    }
}
