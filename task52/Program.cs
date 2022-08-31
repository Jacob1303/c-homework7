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
                matr[i, j] = new Random().Next(1,10);
            }
        }
    }

    static void FindNumbInArray(int[,] array, int m, int n)
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
        int[,] matrix = new int[3, 4];

        FillArray(matrix);
        PrintArray(matrix);
        Console.WriteLine("Введите поочерёдно индекс строки и индекс столбца необходимого Вам элемента");
        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        FindNumbInArray(matrix, m, n);
    }
}