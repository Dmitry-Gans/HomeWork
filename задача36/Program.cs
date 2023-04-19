// Задача 36:
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
Console.WriteLine("Задайте размер массива");
int length = int.Parse(Console.ReadLine());

int[] array = RandomArray(length);
PrintArray(array);
int result = PositionSum(array);
Console.WriteLine($"Сумма чисел нечетных позиций: {result}");

int[] RandomArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-100, 100);
    }
    return array;
}
int PositionSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
void PrintArray(int[]array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}