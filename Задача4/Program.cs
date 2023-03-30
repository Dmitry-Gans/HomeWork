/*Задача 4: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.
*/

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = int.Parse(Console.ReadLine());

int[] array = new int[] {number1, number2, number3};
int size = array.Length;
int index = 0;
int max = 0;

while(index < size)
{
    if(array[index] > max)
    {
        max = array[index];
        index++;
    }
   
    else
    {
        index++;
    }
}
Console.WriteLine($"Максимальное число {max}");
