// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write ("Введите 1-е целое натуральное число: ");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите 2-е целое натуральное число: ");
int number2 = Convert.ToInt32 (Console.ReadLine());

void DegreeOfNumber (int numb1, int numb2)
{
    int count = 1;
    for (int i = 0; i < numb2; i++)
    {
        count = count*numb1;
    }
    Console.Write ($"{numb1}^{numb2} = {count}");
}
void DegreeOfNumber2 (int numb1, int numb2)
{
    int count = 1;
    int degree = 1;
    while (count <= numb2)
    {
        degree = degree*numb1;
        count++;
    }
Console.Write ($"{numb1}^{numb2} = {degree}");
}
DegreeOfNumber2 (number1, number2);