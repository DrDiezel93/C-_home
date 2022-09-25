// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
void numberСube (int numb)
{
    int i = 1;
    while (i <= numb)
    {
        int num = i * i * i;
        Console.WriteLine($"{i,2}  {num,3}");
        i++;
    }
}
numberСube (number);