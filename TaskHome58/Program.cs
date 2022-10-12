// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

Console.WriteLine();
int[,] matr1 = CreateMatrixRndInt(3, 2, 2, 5);
Console.WriteLine("Матрица № 1:");
PrintMatrix(matr1);
Console.WriteLine();
int[,] matr2 = CreateMatrixRndInt(2, 4, 2, 5);
Console.WriteLine("Матрица № 2:");
PrintMatrix(matr2);
Console.WriteLine();

if (matr1.GetLength(1) == matr2.GetLength(0))
{
    Console.WriteLine("Результат перемножения матриц: ");
    int[,] multiMatr = MultiplicationMatrix(matr1, matr2);
    PrintMatrix(multiMatr);
    Console.WriteLine();
}
else Console.WriteLine("Матрицы перемножить нельзя т.к. число столбцов матрицы № 1 не равно числу строк матрицы № 2");
Console.WriteLine();

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multiMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    int k = 0;
    int m = 0;
    for (int i = 0; i < multiMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multiMatrix.GetLength(1); j++)
        {
            multiMatrix[i, j] = matrix1[i, j - k] * matrix2[i - m, j] + matrix1[i, j + 1 - k] * matrix2[i + 1 - m, j];
            k++;
        }
        k = 0;
        m++;
    }
    return multiMatrix;
}