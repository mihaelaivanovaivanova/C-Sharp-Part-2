using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Program
    {
        static string GetName()
        {
           return Console .ReadLine ();
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, {0}!",GetName() ); ;
        }
    }
}
