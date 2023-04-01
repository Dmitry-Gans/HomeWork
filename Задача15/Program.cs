/*Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("Введите число от 1 до 7 и проверь выходной или нет");
int number = int.Parse(Console.ReadLine());
string a = "Будни";
string b = "Выходной";

if (number == 1)
{
    Console.Write(a);
}
if (number == 2)
{
    Console.Write(a);
}
if (number == 3)
{
    Console.Write(a);
}
if (number == 4)
{
    Console.Write(a);
}
if (number == 5)
{
    Console.Write(a);
}
if (number == 6)
{
    Console.Write(b);
}
if (number == 7)
{
    Console.Write(b);
}
if (number < 1 | number > 7)
{
    Console.Write("Такого дня не существует");
}