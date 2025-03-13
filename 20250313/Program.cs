using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20250313_DSA_Machine_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int genNum = 0;
            bool matchCheck;
            bool validNum;

            int[][] bingoValues = new int[5][];
            for (int row = 0; row < bingoValues.Length; row++)
            {
                bingoValues[row] = new int[5];
            }

            for (int row = 0; row < bingoValues.Length; row++)
            {
                for (int column = 0; column < bingoValues[row].Length; column++)
                {
                    matchCheck = true;
                    while (matchCheck == true)
                    {
                        matchCheck = false;
                        genNum = random.Next(((((column + 1) * 15) + 1) - 15), ((column + 1) * 15) + 1);    
                       
                        for (int ro = 0; ro < row; ro++)
                        {
                            if (bingoValues[ro][column] == genNum)
                            {
                                matchCheck = true;
                            }
                        }
                    }
                    bingoValues[row][column] = genNum;
                }
            }

            Console.WriteLine($"B \t I \t N \t G \t O");
            Console.WriteLine($"- \t - \t - \t - \t -");

            for (int row = 0; row < bingoValues.Length; row++)
            {
                for (int column = 0; column < bingoValues[row].Length; column++)
                {
                    Console.Write($"{bingoValues[row][column]} \t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
