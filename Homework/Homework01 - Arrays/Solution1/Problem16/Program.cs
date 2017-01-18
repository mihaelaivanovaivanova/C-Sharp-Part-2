using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List <double> array = new List <double>();
            for (int i = 0; i < n; i++)
            {
                array.Add(double.Parse(Console.ReadLine()));
            }
            double s = double.Parse(Console.ReadLine());
            array.Sort();
            array.Reverse();
            double restSum=s;
            for(int i=0;i< n;i++)
            {
                restSum = s - array[i];
                //if(restSum>0)
                //{
                //    for(int j=i+1;j< n; j++)
                        
                //}
            }
        }
    }
}
