using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cages = new int[205]; // redovete nqma da sa ni .lenght
            int n = 0; // broim redovete
            string currentCage = Console.ReadLine();
            while(currentCage != "END")
            {
                cages[n] = int.Parse (Console.ReadLine());
                n++;
                currentCage = Console.ReadLine();
     
            }
            for (int i = 1; i < n; i++)
            {
                int s = 0;
                for (int j = 0; j < i; j++)// calculate sum s;
                {
                    s += cages[j];
                }
                if (n - i < s) // check if after the firs i until n we have more than s
                    break;
                int sum = 0;
                BigInteger product = 1;
                for (int j = i; j < i+s; j++)// the next s
                {
                    sum+=cages[j];
                    product *= cages[j];
                }
                string next = sum.ToString() + product.ToString();
                for (int j = i+s; j < n; j++) // concatenating the rest of the digits
                    {
                        next += cages[j].ToString();
                    }
                    next = next.Replace("0", ""); // delete 0 and 1 Replace by default makes a 
                    next = next.Replace("1", "");
                    n = next.Length;
                    for (int j = 0; j < n; j++)
                    {
                        cages[j] = next[j] - '0';
                    }
                }
                //string[] end = new string[n];                 --> makes string array
                //for (int i = 0; i < n; i++)
                //{
                //    end[i] = cages[i].ToString();
                //}
               
            
            Console.WriteLine(string.Join(" ", cages.Select(x => x.ToString()).ToArray(), 0, n)); // overload 4
        }
    }
}
