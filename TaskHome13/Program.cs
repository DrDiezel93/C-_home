// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Write ("Введите целое положительное число: ");
int numb = Convert.ToInt32 (Console.ReadLine());

int ThirdNumb (int num)
{
   int result = 0;
   while (num >= 100)
   {
        result = num % 10;
        num = num / 10;
   }
   return result;
}
bool Third2 (int num)
{
    return num < 100;
}
bool Third1 (int num)
{
    return num < 0;
}
if (Third1 (numb)) Console.WriteLine ("Вы ввели отрицательное число");
else if (Third2 (numb)) Console.WriteLine ("В веденном числе 3-й цифры нет");
else 
{
    int Result = ThirdNumb (numb);
    Console.WriteLine ($"Третья цифра в веденном числе: {Result}");
}