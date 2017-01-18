using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Program
    {
        //static int FillMatrix
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int number = 1;
            string letter = Console.ReadLine();
            if (letter=="a")
            {
                for (int i = 0; i < n; i++) 
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[j,i] = number;
                        number++;
                    }
                }
            }
            if(letter =="b")
            {
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            matrix[j, i] = number;
                            number++;
                        }
                    }
                    else
                    {
                        for (int j=n-1;j>=0;j--)
                        {
                            matrix [j,i]= number;
                            number++;
                        }
                    }
                }
            }
            if (letter =="c")
            {
                for (int i = n-1; i >=0; i--)
                {
                    {
                        int innerIndex = 0;
                        int counter = i;
                        for (int j = 0; j < n&&counter <n; j++, counter ++)
                        {
                            matrix[counter, innerIndex] = number;
                            number++;
                            innerIndex++;
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    {
                        int innerindex = 0;
                        
                        for (int j = i+1 ; j < n && innerindex < n; j++)
                        {
                            matrix[innerindex, j] = number;
                            number++;
                            innerindex++;
                        }
                    }
                }
            }
            if(letter =="d")
            {
                string direction = "down";
                int currentRow = 0;
                int currentCol = 0;
                for (int i = 1; i <= n*n; i++)
                {
                    if ((direction =="down") && (currentRow >= n||matrix [currentRow , currentCol ]!=0))
                      {
                        currentRow--;
                        currentCol++;
                         direction = "right";
                      }
                    else if((direction =="right")&&(currentCol>=n || matrix[currentRow, currentCol] != 0))
                        {
                        currentCol--;
                        currentRow--;
                        direction = "up";
                    }
                    else if((direction =="up")&&(currentRow<0 || matrix[currentRow, currentCol] != 0))
                    {
                        currentRow++;
                        currentCol--;
                        direction = "left";
                    }
                    else if((direction == "left") &&(currentCol<0 || matrix[currentRow, currentCol] != 0))
                {
                    currentCol++;
                    currentRow++;
                    direction = "down";
                }
                    matrix[currentRow, currentCol] = i;
                    if (direction == "down")
                    {
                        currentRow++;
                    }
                    else if (direction == "right")
                    {
                        currentCol++;
                    }
                    else if(direction == "up")
                    {
                        currentRow--;
                    }
                    else if (direction == "left")
                    {
                        currentCol--;
                    }
                }
                
            }
            //output
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                  Console.Write(matrix [i,j]);
                    if(j!=n-1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
