// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write ("Введите 1-е целое число: ");
int numb1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите 2-е целое число: ");
int numb2 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите 3-е целое число: ");
int numb3 = Convert.ToInt32 (Console.ReadLine());
int max = numb1;
if (numb1 == numb2 && numb2 == numb3) 
{
	Console.Write ("Все числа равны");
}
else
{	
	if (numb2 > max) max = numb2;
	if (numb3 > max) max = numb3;
    Console.Write ($"Число {max} максимальное из 3-х введенных чисел");
}
