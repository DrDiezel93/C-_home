// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M:  ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:  ");
int numberN = Convert.ToInt32(Console.ReadLine());

int sum = SumElementsRange (numberM, numberN);
Console.Write(sum);

int SumElementsRange (int numb1, int numb2)
{
    int sum = numb1;
    if (numb1 < numb2)
    {
        sum = sum + SumElementsRange (numb1+1, numb2);
    }
    if (numb1 > numb2)
    {
        sum = sum + SumElementsRange (numb1-1, numb2);
    }
    return sum;
}
