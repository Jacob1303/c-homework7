using System;

class Programm
{

    static void PrintArray(double[,] matr)
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

    static void FillArray(double[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = Math.Round(new Random().NextDouble(), 1);
                int k = new Random().Next(0, 2);
                if (k == 1) matr[i, j] = matr[i, j] * -1;
            }
        }
    }

    static void Main(string[] args)
    {
        double[,] matrix = new double[3, 4];
        FillArray(matrix);
        Console.WriteLine("Массив вещественных чисел, заполненный случайной генерацией");
        PrintArray(matrix);
    }
}