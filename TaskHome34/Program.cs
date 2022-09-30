// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int siz = Convert.ToInt32(Console.ReadLine());

int[] threeDigitArray = RandomArray(siz, 100, 1000);
PintArray(threeDigitArray);
int res = EvenOrOddNumber(threeDigitArray);
Console.WriteLine($"Четных чисел в массиве -> {res}");

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

int EvenOrOddNumber(int[] arr)
{
    int result = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) result++;
    }
    return result;
}