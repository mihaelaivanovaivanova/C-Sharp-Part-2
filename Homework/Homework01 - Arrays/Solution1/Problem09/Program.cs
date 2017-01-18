using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            double mostFrequentNum = 0;
            int counter = 1;
            int biggestCounter = 1;
            double currentNum;
            for (int i = 0; i < n; i++)
            {
                currentNum = array[i];
                for (int j = i+1; j < n; j++)
                {
                    if(currentNum == array[j])
                    {
                        counter++;
                        if (counter>biggestCounter )
                        {
                            biggestCounter = counter;
                            mostFrequentNum = currentNum;
                        }
                    }
                    
                }
                counter = 1;
            }
            Console.WriteLine("{0} ({1} times)", mostFrequentNum ,biggestCounter );
        }
    }
}
