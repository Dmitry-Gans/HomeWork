// Задача 27:
// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// 1. Узнать длину массива от заданного числа
// 2. Создать массива
// 3. Вывести сумму чисел

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(SumNum(num));

// Метод суммирующий числа массива
int SumNum(int num)
{
    int[] array = ArrayNum(num);// Создаем массив и присваеваем ему метод ArrayNum
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}

// Метод создания массива
int[] ArrayNum(int num)
{
    int length = SizeNum(num);// создаем переменную типа int с присваиванием метода SizeNum
    int[] array = new int[length];// создаем массив и задаем размер
    for (int i = 0; i < length; i++)
    {
        array[i] = num % 10;// Присваеиваем ячейке последнее число
        num = num / 10;// Удаляем последнее число, для следющего цикла
    }
    return array;// Возвращаем развернутый массив
}

// Метод получения длинны массива от заданного числа
int SizeNum(int num)
{
    int size = 0;
    while (num != 0)
    {
        num /= 10;
        size++;
    }
    return size;
}