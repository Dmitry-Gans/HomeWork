// Задача 66:
// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int number2 = int.Parse(Console.ReadLine());

int result = NumSum(number1, number2);
Console.WriteLine(result);

int NumSum(int m, int n)
{
    if (m <= n)
    {
        n--;
        return NumSum(m, n) + n + 1;
    }
    return 0;
}