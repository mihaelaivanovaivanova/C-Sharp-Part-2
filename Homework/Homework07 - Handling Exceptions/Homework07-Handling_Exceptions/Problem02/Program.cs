using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        static bool ReadNumbers(int start, int end)
        {
            try {
                start.CompareTo(end);
            
        }
        static void Main(string[] args)
        {
                int startNum = 0;
                int endNum = 0;  
            int[] tenNumbers = new int[10]; 
            for (int i = 0; i < 10; i++)
            {
                string number = Console.ReadLine();
                try
                {
                    tenNumbers[i] = int.Parse(number);
                        endNum = tenNumbers[i];
                        if (i > 0)
                        {
                            startNum = tenNumbers[i - 1];
                            ReadNumbers(startNum, endNum);
                        }
                }
                catch // - exception if the input can not be parsed to integers
                {
                    Console.WriteLine("Exception");
                }
            }
        }
    }
}
