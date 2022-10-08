// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Console.Write("Введите общее колличество целых чисел: ");
// int size = Convert.ToInt32(Console.ReadLine());

// if (size > 0) NumberPositiveNumbers(size);

// else Console.WriteLine("Вы ввели некорректное значение");

// void NumberPositiveNumbers(int siz)
// {
//     int count = default; 
//     for (int i = 1; i <= siz; i++)
//     {
//         Console.Write($"Введите {i}-е число: ");
//         int numb = Convert.ToInt32(Console.ReadLine());
//         if (numb > 0) count++;
//     }
//     if (count > 0) Console.WriteLine($"Вы ввели {count} положительных числа");
//     else Console.WriteLine("Вы не ввели положительных чисел");
// }

Console.Write("Input nums (use space to sepparate): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = arr.Count(x => x > 0);
Console.WriteLine($"Count of nums > 0 -> {count}");
