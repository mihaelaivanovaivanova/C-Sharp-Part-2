using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Program
    { static double MaximalApperienceX(double[] inputArray, double x)
        {
            int apperience = 0;
            for (int i = 0; i < inputArray .Length; i++)
            {
                if (inputArray[i] == x)
                    apperience++;
            }
            return apperience; 
        }
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            double[] array = new double[size];
            array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int numberX = int.Parse(Console.ReadLine());
            Console.WriteLine(MaximalApperienceX(array ,numberX));
        }
    }
}
