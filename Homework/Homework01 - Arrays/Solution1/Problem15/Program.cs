using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int devider;
            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }
            for (int i = 1; i < n / 2 - 1; i++)
            {
                devider = array[i];
                if (devider != 1)
                {
                    for (int j = 2 * (i + 1) - 1; j <= n - 1; j += (i + 1))
                    {
                        array[j] = 1;
                    }
                }
            }
            //Array.Sort(array);
            int br = n - 1;
            while (array[br] == 1)
            {
                br--;
            }
            Console.WriteLine(array[br]);
           // Console.WriteLine(array[n - 1]);
        }
    }
}
