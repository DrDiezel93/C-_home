// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows (ряды, строки)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - colums (столбцы)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} |");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void OrderedStringsMatrix (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i, k] < matr[i, k + 1])
                {
                    int maxElementMatr = matr[i, k + 1];
                    matr[i, k + 1] = matr[i, k];
                    matr[i, k] = maxElementMatr;
                }
            }
        }
    }
}
int[,] createMatrix = CreateMatrixRndInt(5, 4, 1, 9);
PrintMatrix(createMatrix);
Console.WriteLine ();
OrderedStringsMatrix (createMatrix);
PrintMatrix(createMatrix);
