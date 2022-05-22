// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Console.WriteLine("Среднее: " + avg);
int[,] CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 4);
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
// i = row;
// j = column;

void FindSmallElement(int[,] array)
{
    int sum1 = 0;
    int sum2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum1 = sum1 + array[0, 0] + array[0, 1] + array[0, 2];
        sum2 = sum2 + array[1, 0] + array[1, 1] + array[1, 2];
        break;
    }


    Console.Write($"{sum1} = {sum2}");
}


int[,] matrix = new int[2, 3];
CreateMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
FindSmallElement(matrix);