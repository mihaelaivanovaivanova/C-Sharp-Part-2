using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        static void Main()
        {
            
            string [] arrayOfPoints = Console.ReadLine().Split(' ').ToArray();
            int length = arrayOfPoints.Length;
            int[] arrayOfPointsInt = new int[arrayOfPoints.Length];
            for (int i = 0; i < length; i++)
            {
                arrayOfPointsInt[i] = int.Parse(arrayOfPoints[i]);
            }
            string[] moves = new string[3];
            string currentInput = Console.ReadLine();
            int counter = 0;
            double totalSum = 0;
            int currentPossition = 0;
            while (currentInput != "stop")
            {
                counter++;
                moves = currentInput.Split(' ').ToArray();
                double middleSum =0;
                for (int i = 0; i < int.Parse(moves[0]); i++)
                {
                    if (moves[1] == "right")
                    {
                        int temp = (currentPossition + int.Parse(moves[2])) % length;
                        middleSum += arrayOfPointsInt[temp];
                        currentPossition = temp;
                    }
                    else
                    {
                        if (currentPossition - (int.Parse(moves[2]) % length) < 0)
                        {
                            int temp =length + currentPossition - (int.Parse(moves[2]) % length);
                            middleSum += arrayOfPointsInt[temp];
                            currentPossition =temp;
                        }
                        else
                        {
                            int temp = currentPossition - (int.Parse(moves[2]) % length);
                            middleSum += arrayOfPointsInt[temp];
                            currentPossition =temp;
                        }
                    }
                }
                totalSum += middleSum;
                middleSum = 0;
                currentInput = Console.ReadLine();
            }
            double result = totalSum / counter;
            Console.WriteLine("{0:F1}",result);
        }
    }
}
