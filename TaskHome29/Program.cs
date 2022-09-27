// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон значений в массиве");
Console.Write("Минимальное значение массива: ");
int numbMin= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон значений в массиве");
Console.Write("Максимальное значение массива: ");
int numbMax = Convert.ToInt32(Console.ReadLine());

int [] array = new int [size];
if (numbMin > numbMax) 
{
    Console.WriteLine("Вы перепутали мминимальное и максимальное значения, но мы Вас поправили");
    FillArray (array, numbMax, numbMin);
}
else FillArray (array, numbMin, numbMax);
Console.Write ("Искомый массив: [");
PintArray (array);
Console.Write ("]");
Console.WriteLine ();

void FillArray(int[] collection, int numb1, int numb2)
{
    int Length = collection.Length;
    Random rnd = new Random ();
    for (int i = 0; i < Length; i++)
    {
        collection[i] = rnd.Next(numb1, numb2+1);
    }
}
void PintArray(int[] col)
{
    int count = col.Length;
    for (int i = 0; i < count-1; i++)
    {
        Console.Write ($"{col[i]}, ");
    }
    Console.Write ($"{col[count-1]}");
}

