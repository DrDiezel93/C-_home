// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write ("Введите значение свободного коэффициента 1-й прямой: b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите значение углового коэффициента 1-й прямой: к1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите значение свободного коэффициента 2-й прямой: b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите значение углового коэффициента 2-й прямой: к2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2) Console.WriteLine ("Прямые не пересакаются т.к. они параллельные");
else
{
    double x = CoordinatesX (k1, b1, k2, b2);
    double y = CoordinatesY (k1, b1, k2, b2);
    Console.WriteLine ($"Координаты точки пересчения прямых: ({x,1}; {y,1})");
}
double CoordinatesX (double k1c, double b1c, double k2c, double b2c)
{
    double xc = (b2c - b1c)/(k1c - k2c);
    return xc;
}
double CoordinatesY (double k1c, double b1c, double k2c, double b2c)
{
    double yc = (k1c*b2c - k2c*b1c)/(k1c - k2c);
    return yc;
}