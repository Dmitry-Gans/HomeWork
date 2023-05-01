// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array3D = GenerateArray3D();
PrintArray3D(array3D);

int[,,] GenerateArray3D()
{
    int[,,] result = new int[3, 3, 3];

    HashSet<int> hashSet = new HashSet<int>();

    Random random = new Random();

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {// Делаем цикл бесконечным
                while(true)
                {
                    int number = random.Next(10, 100);
                    // Если мы не будем пользоваться переменной в Out int,
                    // то можно назвать ее "_", чтобы была как заглушка
                    bool isExist = hashSet.TryGetValue(number, out int _);
                    //Если чесло не существует(нет в hashSet), то добавляем его в массив 
                    if (!isExist)
                    {
                        result[i, j, k] = number;
                        // И в hashSet тоже
                        hashSet.Add(number);
                        // В этом случе останавливаем цикл
                        break;
                    }
                    // А если существует, то нужно заново сгенерировать число, цикл запустится сам
                }
            }
        }

    }
    return result;
}
void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {// Выводим массив и его индексы
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
