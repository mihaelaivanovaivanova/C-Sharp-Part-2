using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01___PHP_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string someInput = (Console.ReadLine());
            int indexOfS = 0;
            StringBuilder inputCodeLineByLine = new StringBuilder();
            while (someInput != "?>")
            {
                inputCodeLineByLine.Append(someInput+Environment.NewLine);
                someInput = Console.ReadLine();
            }
            inputCodeLineByLine.Append("?>");
            // Console.WriteLine(inputCodeLineByLine);
            string[] LineByLine = inputCodeLineByLine.ToString().Split(new string[] { Environment.NewLine },StringSplitOptions.None);
            StringBuilder variables = new StringBuilder();
            for (int i = 1; i <LineByLine .Length-1 ; i++)
            {
                if (LineByLine[i].IndexOf(@"//") > -1 && LineByLine[i].IndexOf(@"/*") > -1)
                {
                    if (LineByLine[i].IndexOf('$') > -1)
                    {
                        /* variables.Append(LineByLine[i].Substring(LineByLine[i].IndexOf('$')+1,
                             LineByLine[i].IndexOf()))*/
                        indexOfS = LineByLine[i].IndexOf('$');
                        
                    }
                }
            }
        }
        
    }
}
