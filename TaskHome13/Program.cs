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
bool NumberLess100 (int num)
{
    return num < 100;
}
bool NegativeNumber (int num)
{
    return num < 0;
}
if (NegativeNumber (numb)) Console.WriteLine ("Вы ввели отрицательное число");
else if (NumberLess100 (numb)) Console.WriteLine ("В веденном числе 3-й цифры нет");
else 
{
    int result2 = ThirdNumb (numb);
    Console.WriteLine ($"Третья цифра в веденном числе: {result2}");
}