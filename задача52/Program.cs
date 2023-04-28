// Задача 52.
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Задайте количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов");
int n = int.Parse(Console.ReadLine());

int[,] matrix = GenerateArray(m, n);
Print2Array(matrix);
PrintArray(FindArithmetic(matrix, m));

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
void PrintArray(double[] array)
{
    Console.WriteLine($"Среднеарифметическое столбцов: [{string.Join("; ", array)}]");
}
int[,] GenerateArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}
double[] FindArithmetic(int[,] array, int m)
{
    double[] sum = new double[array.GetLength(1)];
    double result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            result += array[i, j];
        }
        sum[j] = result / m;
    }
    return sum;
}