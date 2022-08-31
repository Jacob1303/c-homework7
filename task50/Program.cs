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

    static void FindNumbInArray(double[,] array, int m, int n)
    {
        if (m <= array.GetLength(0) && n <= array.GetLength(1))
        {
            Console.WriteLine($"Элемент массива с заданным индексом -  {array[m, n]}");
        }
        else
        {
            Console.WriteLine("Нет такого элемента в массиве");
        }
    }

    static void Main(string[] args)
    {
        double[,] matrix = new double[3, 4];

        FillArray(matrix);
         Console.WriteLine("Массив вещественных чисел, заполненный случайной генерацией");
        PrintArray(matrix);
        Console.WriteLine("Введите поочерёдно индекс строки и индекс столбца необходимого Вам элемента");
        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        FindNumbInArray(matrix, m, n);
    }
}