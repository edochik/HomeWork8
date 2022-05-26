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


void FindSmallSumRow(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
    }
    int index = 0;
    int find = sum; // только надо сделать так, чтобы число автоматически приходило
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int min = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            min += array[i, j];
        }
        if (min < find)
        {
            find = min;
            index = i;
        }

    }
    Console.WriteLine($"{find} {index}");
}


int[,] matrix = new int[3, 5];
CreateMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
FindSmallSumRow(matrix);
