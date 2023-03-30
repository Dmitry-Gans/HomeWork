/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
является ли число чётным (делится ли оно на два без остатка).
*/

Console.WriteLine("Введите число и проверьте, четное оно или нет");
int number = int.Parse(Console.ReadLine());
int result = 0;

if (number % 2 == 0)
{
    Console.WriteLine($"Число {number} четное");
}
else
{
    Console.WriteLine($"Число {number} не четное");
}