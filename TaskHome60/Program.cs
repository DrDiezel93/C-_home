// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrix3D (int rows, int colums, int depth, int min)
{
    int[,,] matrix3D = new int[rows, colums, depth];
    for (int i = 0; i < matrix3D.GetLength(0); i++) // 0 - rows (ряды, строки)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++) // 1 - colums (столбцы)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i, j, k] = min + 3;
                min = matrix3D[i, j, k];
            }
        }
    }
    return matrix3D;
}

void PrintMatrix3D (int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"{matrix3D [i, j, k]} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine ();
    }
}
int [,,] matr3D = CreateMatrix3D (2, 2, 2, 20);
PrintMatrix3D (matr3D);