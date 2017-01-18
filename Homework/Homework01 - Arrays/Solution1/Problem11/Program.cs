using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            double[] array = new double[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            double number = double.Parse(Console.ReadLine());
            Array.Sort(array);
            Console.WriteLine(Array.IndexOf(array , number ));
        }
    }
}
