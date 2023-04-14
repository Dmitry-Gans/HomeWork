/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());

int[] array = ConvertToArray(num);
int[] reverseArray = ReverseArray(array);

PrintArray(array);

bool result = Equals(array, reverseArray);
//Так как метод засунули в переменную result, выводим ее через консоль
Console.WriteLine($" Ответ: {result}");

//Нужно сравнить два массива
bool Equals(int[] array1, int[] array2)
{
    //Сначала сравниваем длины массмвов
    if (array1.Length != array2.Length)
    {
        return false;
    }
    //Сравниваем сами массивы по индексам
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i] != array2[i])
        {
            return false;
        }
    }
    return true;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}
//Создаем метод который перевернет наш массив
int[] ReverseArray(int[] array)
{
    //Cоздаем новый массив и задаем ему длину от оригинального массива
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {   //В начало массива кладем конец массива и добавляем -i,
        //чтобы шаг шел из конца в начало
        result[i] = array[array.Length - 1 - i];
    }
    return result;
}
//Создаем метод которая число 12345 превращает в массив [1,2,3,4,5]
int[] ConvertToArray(int num)
{   //Чтобы создать массив, нужно узнать его длину.
    //Для этого вызываем метод, созданный на строчке 33
    //и помещаем его в переменную
    int length = GetLengthNumber(num);
    //Теперь создаем новый массив и задаем ему длину от заданного числа
    int[] result = new int[length];
    //Заполняем массив через for
    for (int i = 0; i < length; i++)
    {   //Забираем у числа последнюю цифру и кладем в result[i] - начало
        result[i] = num % 10;
        //И уменьшаем наше число на одну цифру
        num = num / 10;
    }
    return result;
}
//Создаем метод, чтобы узнать длину заданного числа
int GetLengthNumber(int num)
{   //Задаем переменную, которая отвечает за длину
    int length = 0;
    //Запускаем цикл, пока число не будет равно 0,
    //как будет равно 0, то программа остановится
    while (num != 0)
    {//Пока число не равно 0, то от числа отнимаем по цифре с каждой итерацией
     //и прибавлем к длине +1
        num = num / 10;
        length++;
    }
    return length;

}
