// Задача 29:
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] array = GenerationArray(8);
PrintArray(array);

int[] GenerationArray(int lenght)
{
    int[] array = new int[lenght];

    Random random = new Random();

    for (int i = 0; i < lenght; i++)
    {
        array[i] = random.Next(0, 10);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.WriteLine($"{string.Join(", ", array)} -> [{string.Join(", ", array)}]");
}