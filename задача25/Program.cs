// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число А");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(Factorial(a,b));

int Factorial(int a, int b)
{// Вводим временную переменную
    int tmp = a;
    for (int i = 1; i < b; i++)
    {//Возводим А в степень при помощи временной перменной
        a = a * tmp ;
    }
    return a;
}