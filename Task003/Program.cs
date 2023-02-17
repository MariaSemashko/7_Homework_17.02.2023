﻿/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,10);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }

        Console.WriteLine();
    }
}

void GetMean (int[,] matrix)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double mean = 0;
        double sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];            
        }

        mean = Math.Round(sum / matrix.GetLength(0), 2);
        Console.Write($"{mean}, ");
    }
}

int[,] matrix = InitMatrix(3, 4);
PrintMatrix(matrix);
GetMean(matrix);