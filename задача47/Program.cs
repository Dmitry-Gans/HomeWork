﻿// Задача 47.
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.WriteLine("Задайте количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов");
int n = int.Parse(Console.ReadLine());

double[,] matrix = GenerateArray(m, n);
Printarray(matrix);

void Printarray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();


    }
}
double[,] GenerateArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(random.Next(1, 100) * 0.1, 1);
        }
    }
    return array;
}
