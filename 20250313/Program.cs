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
            // INITIALIZATION OF VALUES WITH THE RANDOM METHOD
            Random random = new Random();
            int genNum = 0;
            bool matchCheck;
            bool validNum;
            
            // CREATION OF 2D ARRAY AND ASSIGNING 5 SLOTS FOR THE OUTER ARRAY
            int[][] bingoValues = new int[5][];
            
            // ASSIGNING AN ARRAY OF 5 SLOTS FOR EACH OF THE VALUES IN THE OUTER ARRAY
            for (int row = 0; row < bingoValues.Length; row++)
            {
                bingoValues[row] = new int[5];
            }
            
            // THIS IS THE BLOCK OF CODE FOR GENERATING AND ASSIGNING VALUES TO THE SLOTS IN THE 2D ARRAY, THE OUTER ARRAY REPRESENTS THE ROWS AND THE INNER ARRAY REPRESENTS THE COLUMNS
            for (int row = 0; row < bingoValues.Length; row++)
            {
                for (int column = 0; column < bingoValues[row].Length; column++)
                {
                    // THIS WHILE LOOP RUNS WHILE THE BOOLEAN VALUE OF matchCheck IS TRUE,
                    // IT ALWAYS TURNS FALSE EVERYTIME THE LOOP RUNS BUT IF A DUPLICATE NUMBER IS DETECTED, THEN THE matchCheck WILL TURN TRUE.
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
            
                    /* AFTER THE WHILE LOOP IS DONE, THAT MEANS THERE IS NO DUPLICATE NUMBER DETECTED, AND THE GENERATED NUMBER WILL BE ASSIGNED TO THE CORRESPONDING SLOT IN THE ARRAYS
                       BASED ON THE ROWS AND COLUMNS INDICATED IN THE FOR LOOP. */
                    bingoValues[row][column] = genNum;
                }
            }
            
            // PRINTING OF THE BINGO CARD
            Console.WriteLine($"B \t I \t N \t G \t O");
            Console.WriteLine($"- \t - \t - \t - \t -");
            
            
            // THE FOR LOOP WILL NAVIGATE THE NUMBER OF ROWS AND COLUMNS TO DETERMINE THE NUMBER WHICH WILL BE PRINTED.
            // IT PRINTS EACH ROWS ONE BY ONE.
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
