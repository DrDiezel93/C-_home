// Задача 4: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write ("Введите целое число: ");
int numb = Convert.ToInt32 (Console.ReadLine());
if (numb % 2 == 0) Console.Write ($"Число {numb} является четным числом");
else Console.Write ($"Число {numb} НЕ является четным числом");