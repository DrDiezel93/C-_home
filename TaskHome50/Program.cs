// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите позицию элемента в массиве");
Console.Write("Введите номер столбца: ");
int columNumb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер строки: ");
int rowNumb = Convert.ToInt32(Console.ReadLine());


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
void SearchElementMatrix(int[,] matr, int rowNumber, int columNumber)
{
    if (rowNumber <= matr.GetLength(0) && columNumber <= matr.GetLength(1))
    {
        Console.Write($"На заданной позиции находтися числ0: {matr[rowNumber-1, columNumber-1]}");
    }
    else Console.Write("Такого элемента в массиве нет");
}
int[,] createMatrix = CreateMatrixRndInt(5, 4, -10, 10);
PrintMatrix(createMatrix);
SearchElementMatrix(createMatrix, rowNumb, columNumb);