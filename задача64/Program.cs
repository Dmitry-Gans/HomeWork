// Задача 64:
// Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1

Console.WriteLine("Введите число N");
int number = int.Parse(Console.ReadLine());

Array(number);

void Array(int number, int i = 1)
{
    if (number >= i)
    {
        Console.Write($"{number}, ");
        Array(number - 1, i);
    }

}
