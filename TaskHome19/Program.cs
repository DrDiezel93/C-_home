// // // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // // 14212 -> нет
// // // 12821 -> да
// // // 23432 -> да

Console.WriteLine();
Console.Write("Введите целое положительное число, начиная от 10: ");
int number = Convert.ToInt32(Console.ReadLine());

int ReversNumber(int numb)
{
    int numbLittle = numb;
    int numbRevers = 0;
    numb = numb % 10;
    while (numbLittle >= 10)
    {
        numbLittle = numbLittle / 10;
        numbRevers = numb * 10 + numbLittle % 10;
        numb = numbRevers;
    }
    return numb;
}
if (number < 10) Console.WriteLine($"Вы ввели некорректное число");
else
{
    int reversNumber = ReversNumber(number);
    Console.WriteLine();
    if (number == reversNumber) Console.WriteLine($"Введенное число является палиндромом");
    else Console.WriteLine($"Введенное число не является палиндромом");
    Console.WriteLine();
}