// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А");
Console.Write("Xа: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Yа: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Zа: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("Xb: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Yb: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Zb: ");
int zB = Convert.ToInt32(Console.ReadLine());

double Distance(int xac, int yac, int zac, int xbc, int ybc, int zbc)
{
    double result = Math.Sqrt((xbc - xac) * (xbc - xac) + (ybc - yac) * (ybc - yac) + (zbc - zac)*(zbc - zac));
    return result;
}
    double distance = Distance(xA, yA, zA, xB, yB, zB);
    distance = Math.Round(distance, 2, MidpointRounding.ToZero);
    Console.Write($"Расстояние между точками: {distance.ToString(System.Globalization.CultureInfo.GetCultureInfo("en-US"))}");