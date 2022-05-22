// Задача 4: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Не понятно, что надо:(
int[,,] CreateMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[i, j, z] = new Random().Next(0, 9);
            }

        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine("==========");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                Console.Write($" {matrix[i, j, z]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Массив №{i+1}");
    }
}


int[,,] matrix = new int[3, 3, 3];
CreateMatrix(matrix);
PrintMatrix(matrix);