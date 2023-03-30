/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
*/

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
int min = 0;
int max = 0;

if (number1 > number2)
{
    max = number1;
    min = number2;
    Console.WriteLine($"Число {max} больше, число {min} меньше");
}
else if(number1 < number2)
{
    max = number2;
    min = number1;
    Console.WriteLine($"Число {min} меньше, число {max} больше");
}
else
{
    max = number1;
    min = number2;
    Console.WriteLine($"Число {max} и число {min} равны");
}
