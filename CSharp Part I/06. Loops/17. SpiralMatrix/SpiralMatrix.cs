/*
Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20) 
and prints a matrix holding the numbers from 1 to N*N in the form of square spiral */

namespace _17.SpiralMatrix
{
    using System;

    public class SpiralMatrix
    {
        static void Main()
        {

            int input = int.Parse(Console.ReadLine());
            int[,] matrix = new int[input, input];
            int currentRow = 0;
            int currentCol = 0;
            string direction = "right";
            for (int i = 0; i < input * input; i++)
            {
                switch (direction)
                {
                    case "right":
                        if (currentCol == input || matrix[currentRow, currentCol] != 0)
                        {
                            direction = "down";
                            currentCol--;
                            currentRow++;
                            if (i < input * input - 1)
                            {
                                i--;
                            }
                            else
                            {
                                matrix[currentRow, currentCol] = i + 1;
                            }
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                            currentCol++;
                        }
                        break;
                    case "down":
                        if (currentRow == input || matrix[currentRow, currentCol] != 0)
                        {
                            direction = "left";
                            currentCol--;
                            currentRow--;
                            if (i < input * input - 1)
                            {
                                i--;
                            }
                            else
                            {
                                matrix[currentRow, currentCol] = i + 1;
                            }
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                            currentRow++;
                        }
                        break;
                    case "left":
                        if (currentCol < 0 || matrix[currentRow, currentCol] != 0)
                        {
                            direction = "up";
                            currentRow--;
                            currentCol++;
                            if (i < input * input - 1)
                            {
                                i--;
                            }
                            else
                            {
                                matrix[currentRow, currentCol] = i + 1;
                            }
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                            currentCol--;
                        }
                        break;
                    case "up":
                        if (currentRow < 1 || matrix[currentRow, currentCol] != 0)
                        {
                            direction = "right";
                            currentCol++;
                            currentRow++;
                            if (i < input * input - 1)
                            {
                                i--;
                            }
                            else
                            {
                                matrix[currentRow, currentCol] = i + 1;
                            }
                        }
                        else
                        {
                            matrix[currentRow, currentCol] = i + 1;
                            currentRow--;
                        }
                        break;
                }
            }

            for (int row = 0; row < input; row++)
            {
                for (int col = 0; col < input; col++)
                {
                    Console.Write(matrix[row, col].ToString()+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}


