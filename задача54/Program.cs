// Задача 54:
// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int b = int.Parse(Console.ReadLine());

int[,] matrix = GenerateArray(a, b);
PrintArray(matrix);
Console.WriteLine();

Sorting(matrix);
PrintArray(matrix);

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
void PrintArray(int[,] array)
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
void Sorting(int[,] array)
{
    int max = 0;
    int indexMax = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            max = array[i, j];
            indexMax = j;

            for (int k = j; k < array.GetLength(1); k++)
            {
                if(max < array[i,k])
                {
                    max = array[i,k];
                    indexMax = k;
                }
            }
            if(indexMax != j)
            {
                int tmp = array[i,j];
                array[i,j] = array[i, indexMax];
                array[i, indexMax] = tmp;
            }
        }

    }
}
