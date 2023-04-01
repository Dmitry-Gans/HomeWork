﻿/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите любое число");
int number = int.Parse(Console.ReadLine());
int result = 0;

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (number < 1000)
{
    result = number % 10;
    Console.WriteLine(result);
}
else
{
    while (number > 1000)
    {
        number = number / 10;
        result = number % 10;
    }
    Console.WriteLine(result);
}
