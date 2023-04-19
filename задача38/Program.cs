// Задача 38:
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Задайте размер массива");
int length = int.Parse(Console.ReadLine());

int[] array = RandomArray(length);
PrintArray(array);
Console.WriteLine($"Максимальный элемент массива равен {NumberMax(array)}");
Console.WriteLine($"Минимальный элемент массива равен {NumberMin(array)}"); 
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {NumberMax(array) - NumberMin(array)}");

int[] RandomArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}
int NumberMin(int[] array)
{
    int min = 100;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
int NumberMax(int[] array)
{
    int max = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}