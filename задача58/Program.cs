// Задача 58:
// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк у 1 массива");
int rowsA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов у 1 массива");
int colsA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк у 2 массива");
int rowsB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов у 2 массива");
int colsB = int.Parse(Console.ReadLine());

int[,] matrix = GenerateArray(rowsA, colsA);
Print2Array(matrix);
Console.WriteLine();
int[,] matrix1 = GenerateArray1(rowsB, colsB);
Print2Array(matrix1);
int[,] result = SumMatrix(matrix, matrix1);
Console.WriteLine();
Print2Array(result);
// Console.WriteLine($"Минимальная сумма находится на {MinSumLine(matrix)} строчке");

int[,] GenerateArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random random = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}
int[,] GenerateArray1(int a, int b)
{
    int[,] array = new int[a, b];
    Random random = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = random.Next(1, 10);
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
int[,] SumMatrix(int[,] array, int[,] array1)
{
    int[,] result = new int[array.GetLength(0), array1.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            int sum = 0;

            for (int k = 0; k < array.GetLength(1); k++)
            {
                sum += array[i,k] * array1[k,j];
            }
            result[i,j] = sum;
        }
        
    }
    return result;
}