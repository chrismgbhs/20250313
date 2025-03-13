using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _20250313
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Use a single jagged array. This should be the only array in your program,
                Each COLUMN of the BINGO card corresponds to a sub array in the jagged array.
                The generation of numbers must be on a per ROW basis in reference to the BINGO card.
                Checking and preventing duplicate numbers must be done as the numbers are generated.
                    a. There should only be one random number generation call in the whole program
                    b. Allowable numbers: B(1-15) I(16-30) N(31-45) G(46-60) O(60-75)
                    c. There is no FREE space, it should be filled up with a number
                Display the card. 
            */
            Random random = new Random();
            int genNum = 0;
            bool matchCheck;
            bool validNum;

            int[][] bingoValues = new int[5][];
            for (int row = 0; row < bingoValues.Length; row++)
            {
                bingoValues[row] = new int[5];
                Console.WriteLine($"5 slots were created for row {row + 1}");
            }

            for (int row = 0; row < bingoValues.Length; row++)
            {
                for (int column = 0; column < bingoValues[row].Length; column++)
                {
                    matchCheck = false;
                    while (matchCheck == false)
                    {
                        validNum = false;
                        while (validNum == false)
                        {
                            genNum = random.Next(1, 76);

                            if (row == 0 && genNum > 15)
                            {
                                validNum = false;
                            }

                            else if (row == 1 && (genNum > 30 || genNum < 16))
                            {
                                validNum = false;
                            }

                            else if (row == 2 && (genNum > 45 || genNum < 31))
                            {
                                validNum = false;
                            }

                            else if (row == 3 && (genNum > 60 || genNum < 46))
                            {
                                validNum = false;
                            }

                            else if (row == 4 && (genNum > 60 || genNum < 46))
                            {
                                validNum = false;
                            }

                            else
                            {
                                validNum = true;
                            }
                        }
                        
                        for (int ro = 0; ro < bingoValues.Length; ro++)
                        {
                            for (int col = 0; col < bingoValues[ro].Length; col++)
                            {
                                if (genNum == bingoValues[ro][col])
                                {
                                    matchCheck = true;
                                }

                                else
                                {
                                    bingoValues[row][column] = genNum;
                                    Console.WriteLine($"{genNum} has been assigned to bingo values row {row} column {col}");
                                }
                            }
                        }
                    }  
                }
            }

            for (int row = 0; row < bingoValues.Length; row++)
            {
                for (int column = 0; column < bingoValues[row].Length; column++)
                {
                    Console.Write($"{bingoValues[row][column]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
