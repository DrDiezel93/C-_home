// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine ();
Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) Console.WriteLine ($"Вы ввели неккоретное число");
else SumFigureOfNumber (number);
Console.WriteLine ();
void SumFigureOfNumber (int numb)
{
    int sum = 0; 
    while (numb > 0)
    {
        sum = sum + numb % 10;
        numb = numb / 10;
    }
    Console.WriteLine ($"Сумма цифр в веденном числе = {sum}");
}
