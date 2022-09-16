// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write ("Введите целое положительное ненулевое число: ");
int numb = Convert.ToInt32 (Console.ReadLine());
if (numb <= 1)
{
Console.Write ("Вы ввели неверное число");
}
else
{	int count = 2;
	while (count <= numb)
	{
	Console.Write ($"{count} ");
	count = count + 2;
	}	 
}