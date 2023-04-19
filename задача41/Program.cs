// Задача 41:
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Задайте размер массива");
bool isParsed = int.TryParse(Console.ReadLine(), out int size);
if (!isParsed)// Проверка на число
{
    Console.WriteLine("Введите число"); // Если введено не число
    return;// Останавливаем программу, так как нет цикла
}
int[] array = FillInArray(size);
PrintArray(array);
int result = CheckingNumber(array);
// Запускаем проверку написания слова "Число/Числа/Чисел" 
if (result == 0 & result >= 10)
{
    Console.WriteLine($"Пользователь ввел {result} чисел больше 0");
}
else if(result >= 2 & result <= 4)
{
    Console.WriteLine($"Пользователь ввел {result} числа больше 0");
}
else if(result == 1)
{
    Console.WriteLine($"Пользователь ввел {result} число больше 0");
}

// Метод создания массива
int[] FillInArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size;)// i++ в данной части не указывается
    //так как ниже идет обработка, когда именно увеличиваем итератор
    {
        Console.WriteLine($"Введите число {i + 1}");// Просьбы ввести число (для каждого элемента массива, так как работа происходит в цикле)
        bool isParsed = int.TryParse(Console.ReadLine(), out int num);
        if (!isParsed)
        {
            Console.WriteLine("Введите число");
            continue; // Повторяем цикл, так как мы не увеличили итератор (он увеличивается только при введении числа)
        }
        else// Если введено число
        {
            array[i] = num;// Записываем число в массив
            i++;// Только теперь увеличиваем итертор
        }
    }
    return array;
}
// Метод проверки числа, больше 0
int CheckingNumber(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}