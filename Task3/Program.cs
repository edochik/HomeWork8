// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] FirstMatrix =  {{5, 2},
                       {3, 1},
                            };

int[,] SecondMatrix = {{4, 6},
                       {5, 2},
                            };

int[,] FindMultipTwoMatrix(int[,] FirstMatrix, int[,] SecondMatrix)
{
    int[,] m = new int[FirstMatrix.GetLength(0), SecondMatrix.GetLength(1)];
    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < SecondMatrix.GetLength(0); j++)
        {
            for (int k = 0; k < SecondMatrix.GetLength(1); k++)
            {
                m[i, k] = m[i, k] + FirstMatrix[i, j] * SecondMatrix[j, k];
            }
        }
    }
    return m;
}

int[,] m = FindMultipTwoMatrix(FirstMatrix, SecondMatrix);

void PrintFindMultipTwoMatrix(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            Console.Write(m[i, j] + " ");
        }
        Console.WriteLine();
    }
}

PrintFindMultipTwoMatrix(FindMultipTwoMatrix(FirstMatrix, SecondMatrix));