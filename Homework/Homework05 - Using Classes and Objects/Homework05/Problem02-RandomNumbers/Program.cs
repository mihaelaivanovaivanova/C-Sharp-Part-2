using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(number.Next (100,200));
            }

        }
    }
}
