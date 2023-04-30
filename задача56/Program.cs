// Задача 56:
// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int b = int.Parse(Console.ReadLine());

int[,] matrix = GenerateArray(a, b);
Print2Array(matrix);
Console.WriteLine($"Минимальная сумма находится на {MinSumLine(matrix)} строчке");

int[,] GenerateArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random random = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void Print2Array(int[,] array)
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
int MinSumLine(int[,] array)
{
    int min = 0;
    int indexMin = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tmp = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            tmp += array[i, j];
        }
        if (i == 0)
        {
            min = tmp;
        }
        if (min > tmp)
        {
            min = tmp;
            indexMin = i;
        }
    }
    return indexMin;
}