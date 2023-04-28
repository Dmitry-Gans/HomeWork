// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k1");
int k1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите b2");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2");
int k2 = int.Parse(Console.ReadLine());

string result = Intersection(b1, k1, b2, k2);
Console.WriteLine(result);

string Intersection(double b1, double k1, double b2, double k2)
{
    string result = string.Empty;

    double x = 0;
    double y = 0;

    if (k1 - k2 == 0)// Запускаем проверку, чтобы небыло деления на 0
    {
        result = $"На 0 делить нельзя";
        return result;
    }
    // Приступаем к решению по формуле
    x = -(b1 - b2) / (k1 - k2);
    y = k1 * x + b1;

    result = $"Точка пересечения двух прямых находится в координате ({x}; {y})";
    return result;
}