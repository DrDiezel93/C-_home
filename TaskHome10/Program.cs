// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.Write ("Введите целое положительное трехзначное число: ");
int numb = Convert.ToInt32 (Console.ReadLine());
int ThirdNumb (int num)
{
    int num1 = num / 10;
    int result = num1 % 10;
    return result; 
}
bool Third (int num2)
{
    return num2 >= 100 && num2 < 1000;
}
if (Third (numb)) 
{
int Result = ThirdNumb (numb);
Console.WriteLine ($"Второй цифрой из числа {numb} является {Result}");
}
else Console.WriteLine ("Вы ввели неверное число");