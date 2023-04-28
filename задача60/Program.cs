// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GenerateArray3D()
PrintArray(array)
{
    int[,,] result = new int[5, 5, 5];
    HashSet<int> hashSet = new HashSet<int>();

    Random random = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                while (true)
                {
                    int number = random.Next(10; 100);
    bool isExists = hashSet.TryGetValue(number, out int _);
    if (!esExists)
    {
        result[i, j, k] = number;
        hashSet.Add(number);
        break;
    }
}
    }
        }
    return result;
}
voud PrintArray(int[,,] array)
{
    int[,,] result = new int[3, 3, 3];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                Console.WriteLine($"{}");
            }
        }
    }