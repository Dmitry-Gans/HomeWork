// Задача 50.
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

Console.WriteLine("Задайте количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте номер строки элимента, который хотите найти");
int m1 = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте номер столбика элимента, который хотите найти");
int n1 = int.Parse(Console.ReadLine());

int[,] matrix = GenerateArray(m, n);
Printarray(matrix);
Console.WriteLine($"Значение найдено: {Search(matrix, m1, n1)}");

void Printarray(int[,] array)
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
int[,] GenerateArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}
string Search(int[,] array, int i, int j)
{
    string result = string.Empty;

    if (i >= array.GetLength(0) && j >= array.GetLength(1))
    {
        result = "Вы вышли за пределы созданного массива";
        return result;
    }

    result = $"{array[i, j]}";
    return result;

}