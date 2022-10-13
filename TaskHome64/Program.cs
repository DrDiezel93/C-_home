﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write ('"');
NaturalNumbers(number);
Console.Write (1);
Console.Write ('"');

void NaturalNumbers(int num)
{
    if(num == 1) return;
    Console.Write($"{num}, ");
    NaturalNumbers(num - 1); 
}
