/*
Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/
// 1. Создать массив.+
// 2. Напечатать массив.+ 
// 3. Метод принимает в себя массив и вы выводит другой массив с упорядоченными элементами. - 


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




void SelectionSort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int MaxI = 0;
            int MaxJ = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] > matrix[MaxI, MaxJ]) matrix[MaxI, MaxJ] = matrix[i, j];
            }
            int buffer = matrix[i, j];
            matrix[i, j] = matrix[MaxI, MaxJ];
            matrix[MaxI, MaxJ] = buffer;

        }
    }
}


int[,] matrix = new int[3, 3];
int str = matrix.GetLength(0);
CreateMatrix(matrix);
PrintMatrix(matrix);
SelectionSort(matrix);
Console.WriteLine();
PrintMatrix(matrix);

