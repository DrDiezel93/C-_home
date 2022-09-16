// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write ("Введите 1-е целое число: ");
int numb1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите 2-е целое число: ");
int numb2 = Convert.ToInt32 (Console.ReadLine());
if (numb1 == numb2)
{
	Console.Write ("Числа равны");
}
if (numb1 > numb2)
{
	Console.Write ($"Число {numb1} большее, а число {numb2} меньшее");
}
if (numb1 < numb2)
{
	Console.Write ($"Число {numb2} большее, а число {numb1} меньшее");
}