using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            try
            {
                if (double.IsNaN(Math.Sqrt(double.Parse(number))))
                    {
                    Console.WriteLine("Invalid number");
                }
                else
                Console.WriteLine("{0:F3}",Math.Sqrt(double.Parse(number)));
            }
            catch 
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
