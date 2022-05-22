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
            matrix[i, j] = new Random().Next(1, 4);
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
    int sum = 0;
    int j = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];

        }
        Console.WriteLine($"{i + 1} {sum}");
    }

}


int[,] matrix = new int[3, 2];
CreateMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
FindSmallElement(matrix);

/*
int[] CreateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 4);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}
int SumArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}
int[] array = new int[4];
CreateArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write(SumArray(array));
*/