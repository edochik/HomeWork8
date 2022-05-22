// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Console.WriteLine("Среднее: " + avg);

double[] CreateArray(double[] array)
{
    for (double i = 0; i < array.Length; i++)
    {
        array[(int)i] = new Random().NextDouble()*0.1;
    }
    return array;
}

void PrintArray(double[] array)

{
    for (double i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[(int)i]}");
    }
}

double[] array = new double[6];

int AveregNumberArray(int[] array)
{
    int resultA = 0;
    int resultB = 0;
    int avg = 0;
    // for (int i = 0; i < array.Length; i++)
    // {
        // if (array[i] > -1) resultA += 1;
    // }
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > 0) resultB += array[j];
    }
    return avg = resultB / array.Length;
}

CreateArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write(AveregNumberArray(array));