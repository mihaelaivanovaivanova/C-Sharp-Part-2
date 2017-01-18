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
            int sizeArray1 = int.Parse(Console.ReadLine());
           // int sizeArray2 = int.Parse(Console.ReadLine());
            int[] array1 = new int[sizeArray1];
            int[] array2 = new int[sizeArray1];
            for (int i = 0; i < sizeArray1 ; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < sizeArray1; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            bool areSame = true;
            //if (sizeArray1 !=sizeArray2 )
            //{
            //    areSame = false;
            //}
            
                for (int i = 0; i < sizeArray1 ; i++)
                {
                    if (array1[i] != array2[i])
                        areSame = false;
                }
            
            Console.WriteLine(areSame? "Equal":"Not equal");
        }
    }
}
