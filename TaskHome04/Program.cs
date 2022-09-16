// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write ("Введите 1-е целое число: ");
int numb1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите 2-е целое число: ");
int numb2 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите 3-е целое число: ");
int numb3 = Convert.ToInt32 (Console.ReadLine());
if (numb1 == numb2 && numb2 == numb3) 
{
	Console.Write ("Все числа равны");
}
else
{
	if (numb1 == numb2 && numb2 > numb3) Console.Write ($"1-е и 2-е числа ({numb2}) равны и они больше 3-го числа ({numb3})");
	if (numb2 == numb3 && numb2 > numb1) Console.Write ($"2-е и 3-е числа ({numb2}) равны и они больше 1-го числа ({numb1})");
	if (numb1 == numb3 && numb1 > numb2) Console.Write ($"1-е и 3-е числа ({numb1}) равны и они больше 2-го числа ({numb2})");
    if (numb1 == numb2 && numb2 < numb3) Console.Write ($"Число {numb3} максимальное из 3-х введенных чисел");
	if (numb2 == numb3 && numb2 < numb1) Console.Write ($"Число {numb1} максимальное из 3-х введенных чисел");
	if (numb1 == numb3 && numb1 < numb2) Console.Write ($"Число {numb2} максимальное из 3-х введенных чисел");
    if (numb1 > numb2 && numb1 > numb3) Console.Write ($"Число {numb1} максимальное из 3-х введенных чисел");
    if (numb1 > numb2 && numb1 < numb3) Console.Write ($"Число {numb3} максимальное из 3-х введенных чисел");
    if (numb1 < numb2 && numb2 > numb3) Console.Write ($"Число {numb2} максимальное из 3-х введенных чисел");
    if (numb1 < numb2 && numb2 < numb3) Console.Write ($"Число {numb3} максимальное из 3-х введенных чисел");
}
