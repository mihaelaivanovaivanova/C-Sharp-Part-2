using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class Program { 
    
        static double SumOfPolinoms(double[] ArrayOne, double [] ArrayTwo, int currentPossition)
    {
        return (ArrayOne[currentPossition] + ArrayTwo[currentPossition]);
    }
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            double[] firstPolinoms = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] secondtPolinoms = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] rezultPolinoms = new double[size];
            for (int i = 0; i < size; i++)
            {
            rezultPolinoms[i] = SumOfPolinoms(firstPolinoms, secondtPolinoms, i);
            }
            for (int i = 0; i < size; i++)
            {
                if(i<size-1)
                Console.Write(rezultPolinoms [i]+" ");
                else
                    Console.Write(rezultPolinoms[i]);
            }
        }
    }
}
