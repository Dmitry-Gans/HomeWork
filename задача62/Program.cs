// Задача 62.
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] spiral = SpiralArray(4, 4);
Print2Array(spiral);

int[,] SpiralArray(int sizeRow, int sizeCol)
{
    int[,] array = new int[sizeRow, sizeCol];

    int row = 0;
    int col = 0;
    int value = 1;
    int indexSizeRow = 0;
    int indexSizeCol = 0;

    bool start = true;
    int status = 0; // Направление движения: 0 - вправо, 1 - вниз, 2 - влево, 3 - вверх

    while (start)
    {
        if (status == 0)
        {
            while (col < sizeCol - indexSizeCol)
            {
                array[row, col] = value;
                value++;
                col++;
            }
            col = sizeCol - indexSizeCol - 1;
            row++;
            status = 1;
        }
        if (status == 1)
        {
            while (row < sizeRow - indexSizeRow)
            {
                array[row, col] = value;
                value++;
                row++;
            }
            row = sizeRow - indexSizeRow - 1;
            indexSizeRow++;
            col--;
            status = 2;
        }
        if (status == 2)
        {
            while (col >= 0 + indexSizeCol)
            {
                array[row, col] = value;
                value++;
                col--;
            }
            col = 0 + indexSizeCol;
            indexSizeCol++;
            row--;
            status = 3;
        }
        if (status == 3)
        {
            while (row >= 0 + indexSizeRow)
            {
                array[row, col] = value;
                value++;
                row--;
            }
            row = 0 + indexSizeRow;
            col++;
            status = 0;
        }
        if (indexSizeCol == sizeCol - (sizeCol / 2) || indexSizeRow == sizeRow - (sizeRow / 2))
        {
            start = false;
        }
    }
    return array;
}
void Print2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}