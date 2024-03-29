﻿// Задача 68:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int number2 = int.Parse(Console.ReadLine());

int result = Acerman(number1, number2);
Console.WriteLine(result);

int Acerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Acerman(m - 1, 1);
    }
    return Acerman(m-1, Acerman(m,n-1));
}