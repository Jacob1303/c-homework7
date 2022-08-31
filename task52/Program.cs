//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

using System;

class Programm
{

    static void PrintArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static void FillArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(1, 10);
            }
        }
    }

    static void AverageElementsColumn(int[,] array)
    {
        double[] sum = new double[array.GetLength(1)];
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                sum[i] += array[j, i];
            }
        }
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum[i] = Math.Round(sum[i] / (array.GetLength(0)), 1);
            Console.Write("|" + sum[i] + "| ");
        }
    }

    static void Main(string[] args)
    {
        int[,] matrix = new int[3, 4];

        FillArray(matrix);
        PrintArray(matrix);
        Console.WriteLine(" ");
        Console.Write("Среднее арифметическое каждого столбца: ");
        AverageElementsColumn(matrix);
    }
}