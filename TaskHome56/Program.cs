// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SumElementsRowsMatrix(int[,] matr)
{
    int sum = default;
    int[] array = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }
        array[i] = sum;
        sum = 0;
    }
    return array;
}
void MinSumElementsRowsMatrix(int[] arr)
{
    int minElementIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arr[minElementIndex]) minElementIndex = i;
    }
    Console.WriteLine($"Наименьшая сумма элеметов матрицы в строке: {minElementIndex + 1}");
}

int[,] matrix = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(matrix);
int[] array = SumElementsRowsMatrix(matrix);
Console.WriteLine();
MinSumElementsRowsMatrix(array);
Console.WriteLine();

