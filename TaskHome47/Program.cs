// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите размер двумерного массива ");
Console.Write("Число строк в дмумерном массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Число столбцов в дмумерном массиве: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон значений в двумерном массиве");
Console.Write("Минимальное значение элементов массива: ");
int minNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Максимальное значение элементов массива: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());

double[,] CreateMatrixRndDouble(int row, int colum, int min, int max)
{
    double[,] matrix = new double[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows (ряды, строки)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - colums (столбцы)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(matrix[i, j], 1);
        }
    }
    return matrix;
}
void PrintMatrixDouble(double[,] matrix)
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
double[,] doubleMatrix = CreateMatrixRndDouble(rows, colums, minNumber, maxNumber);
PrintMatrixDouble(doubleMatrix);