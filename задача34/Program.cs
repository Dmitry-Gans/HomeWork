// Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int length = int.Parse(Console.ReadLine());

int[] array = RandomArray(length);
PrintArray(array);

int result = EvenNumbers(array);
Console.WriteLine($"Количество четных чисел массива: {result}");

// Метод заполнения случайного массива
int[] RandomArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(99, 1000);
    }
    return array;

}
// Метод определения количества четных чисел
int EvenNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2  == 0)// Если остаток деления значения элемента массива на 2 равен 0, то число четное
        {
            result++;
        }
    }
    return result;

}
void PrintArray(int[] array)
{
    Console.WriteLine($"Масив: [{string.Join(", ", array)}]");
}