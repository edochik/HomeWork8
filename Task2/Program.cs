// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 9);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}");
        }
        Console.WriteLine();
    }
}


(int, int) FindSmallSumRow(int[,] array)
{
    int SumArray = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumArray += array[i, j];
        }
    }
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int min = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            min += array[i, j];
        }
        if (min < SumArray)
        {
            SumArray = min;
            index = i;
        }

    }
    return (index, SumArray);
}

int[,] matrix = new int[3, 5];

CreateMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.Write(FindSmallSumRow(matrix));


