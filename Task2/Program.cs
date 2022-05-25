// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Console.WriteLine("Среднее: " + avg);
/*
1. Создать массив
2. Напечатать массив.
3.1. Счет строк.
3.2. Сравнение строк
3.3. Найти строку с наименьшей суммой;
3.4. Вывести среднее значение;
*/
// не понятно как разделить строки, чтобы вместе их не считать.
// не понятно как счетчик считает

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
// i = row;
// j = column;

void FindSmallElement(int[,] array)
{

    int find = 100; // только надо сделать так, чтобы число автоматически приходило
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int min = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            min += array[i, j];

        }

        if (min < find) find = min;

    }
    Console.WriteLine(find);
}


int[,] matrix = new int[4, 4];
CreateMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
FindSmallElement(matrix);
