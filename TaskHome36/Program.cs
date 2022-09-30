// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int siz = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон значений в массиве");
Console.Write("Минимальное значение массива: ");
int numbMin= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон значений в массиве");
Console.Write("Максимальное значение массива: ");
int numbMax = Convert.ToInt32(Console.ReadLine());

int[] randomArray = RandomArray(siz, numbMin, numbMax);
PintArray(randomArray);
int sum = sumOddNumbers (randomArray);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве = {sum}");

int[] RandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine($"]");
}

int sumOddNumbers (int [] arr)
{
    int sum = default;
    for (int i = 1; i < arr.Length; i=i+2) sum = sum + arr [i];
    return sum;
}