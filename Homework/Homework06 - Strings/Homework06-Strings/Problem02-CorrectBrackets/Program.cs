using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_CorrectBrackets
{
    class Program
    {
        static bool CountBrackets(string expression)
        {
            int countOpeningBrackets = 0;
            int countClosingBrackets = 0;

            bool equals = true;
            for (int i = 0; i < expression .Length; i++)
            {
                if(expression[i]==')')
                {
                    countClosingBrackets++;
                }
                if (expression[i] == '(')
                {
                    countOpeningBrackets++;
                }
            }
            if (countOpeningBrackets != countClosingBrackets)
                equals = false;
            return (equals);
        }
        static void Main(string[] args)
        {
            string inputExpression = Console.ReadLine();
            if(CountBrackets(inputExpression)==false)
            {
                Console.WriteLine("Incorrect");
            }
            else
            {

                Console.WriteLine("Correct");
            }
        }
    }
}
