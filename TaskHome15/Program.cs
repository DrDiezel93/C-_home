// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Write ("Введите цифру от 1 до 7: ");
int day = Convert.ToInt32 (Console.ReadLine());

bool Weekend (int day1) 
{
return day1 == 6 || day1 == 7;
}
bool NotDay (int day1) 
{
return day1 < 1 || day1 > 7;
}
if (NotDay (day)) Console.WriteLine("Вы ввели некорректное значение");
else if (Weekend (day)) Console.WriteLine("Сегодня выходной день");
else Console.WriteLine("Сегодня будний день");

// Console.Write ("Введите цифру от 1 до 7: ");
// string day = Console.ReadLine();

// bool Weekend (string Day) 
// {
//     return Day.ToLower()=="6" || Day.ToLower()=="7";
// }
// if (Weekend (day)) Console.WriteLine("Сегодня выходной день");
// else Console.WriteLine("Сегодня будний день");