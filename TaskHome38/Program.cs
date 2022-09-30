// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон значений в массиве");
Console.Write("Минимальное значение массива: ");
int numbMin= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон значений в массиве");
Console.Write("Максимальное значение массива: ");
int numbMax = Convert.ToInt32(Console.ReadLine());

double[] randomArray = RandomArray(size, numbMin, numbMax);
PintArray(randomArray);
double difference = MaxNumberOnArray (randomArray) - MinNumberOnArray (randomArray);
difference = Math.Round(difference, 1, MidpointRounding.AwayFromZero);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива -> {difference.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))} ");

double [] RandomArray(int size, int min, int max)
{
    double[] dubArray = new double [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
       dubArray[i] = rnd.NextDouble() * (max - min) + min;
       dubArray[i] = Math.Round(dubArray[i], 1, MidpointRounding.AwayFromZero);
    }
    return dubArray;
}

void PintArray(double [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i].ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}, ");
        else Console.Write($"{array[i].ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}");
    }
    Console.WriteLine($"]");
}

double MinNumberOnArray (double [] arr)
{
        double minNumb = arr [0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr [i] < minNumb) minNumb = arr[i];
        }
        return minNumb;
}

double MaxNumberOnArray (double [] ar)
{
        double maxNumb = ar [0];
        for (int i = 0; i < ar.Length; i++)
        {
            if (ar [i] > maxNumb) maxNumb = ar[i];
        }
        return maxNumb;
}