using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Program
    {
        static string ToBinary(string x) // covertirame do binary i slagame nulo ot lqvo
        {
           return  Convert.ToString(byte.Parse (x), 2).PadLeft (8,'0');
        }
        static void Main(string[] args)
        {
           var binaryCode =string.Join("",  Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
             var code =  binaryCode.Split(new char[] { '0' }, StringSplitOptions.RemoveEmptyEntries).Select(x=>x.Length);
            int n = int.Parse(Console.ReadLine());
            char[] reveresedTable = new char[n + 1];
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                int index = int.Parse(line.Substring(1));
                reveresedTable[index] = line[0];
            }
            var text = code.Select(x => reveresedTable[x]).ToArray();
            Console.WriteLine(text);
        }
    }
}
