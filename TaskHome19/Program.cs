﻿// // // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // // 14212 -> нет
// // // 12821 -> да
// // // 23432 -> да

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000)
{
    Palindrom (number);
}
else Console.WriteLine($"Вы ввели некорректное число");

void Palindrom (int numb)
{
    int lastOfNumber = numb % 10;
    int firstOfNumber = numb / 10000;
    if (lastOfNumber == firstOfNumber) 
    {
        double numberNext = Convert.ToDouble(numb % 10000);
        numb = Convert.ToInt32(numberNext) / 10;
        int lastOfNumber2 = numb % 10;
        int firstOfNumber2 = numb / 100;
        if (lastOfNumber2 == firstOfNumber2) Console.WriteLine($"Введенное число является палиндромом");
        else Console.WriteLine($"Введенное число не является палиндромом");
    } 
    else Console.WriteLine($"Введенное число не является палиндромом");
}


// ПОСТАРАЮСЬ ДО СЕМИНАРА ДОДЕЛАТЬ ОБЩЕЕ РЕШЕНИЕ
// int DigitNumber(int num)
// {
//     int digit = 0;
//     while (num > 0)
//     {
//         num = num / 10;
//         digit = digit + 1;
//     }
//     return digit;
// }
// int degree10 = DigitNumber(number) - 1;
// int lastOfNumber = number % 10;
// int firstOfNumber = number / Convert.ToInt32(Math.Pow(10, (degree10)));
// if (lastOfNumber != firstOfNumber) Console.WriteLine($"Введенное число не является палиндромом");
// else
//     while (degree10 > 0) 
//     {
//       lastOfNumber = number % 10;
//       firstOfNumber = number / Convert.ToInt32(Math.Pow(10, (degree10)));
//       if (lastOfNumber == firstOfNumber) 
//       {
//             double numberNext = Convert.ToDouble(number % Convert.ToInt32(Math.Pow(10, (degree10))));
//             number = Convert.ToInt32(numberNext) / 10;
//             Console.WriteLine($"{number}");
//       }
//     degree10 = degree10 - 2;
//     else

// } 
// Console.WriteLine($"Введенное число является палиндромом");

    
// //     while (deg > 0)
// //     {
// //         int lastOfNumber = numb % 10;
// //         int firstOfNumber = numb / Convert.ToInt32(Math.Pow(10, (deg)));
// //         if (lastOfNumber != firstOfNumber) Console.WriteLine($"Введенное число не является палиндромом");
// //         else     
// //         {
// //             double numberNext = Convert.ToDouble(number % Convert.ToInt32(Math.Pow(10, (deg))));
// //             numb = Convert.ToInt32(numberNext) / 10;
// //         }
// //         deg = deg - 2;
// //     }
// // }
// // Palindrom (number, DigitNumber(number))

// // while (degree10 > 0)
// // {
// //     int lastOfNumber = number % 10;
// //     Console.WriteLine($"{lastOfNumber}");
// //     int firstOfNumber = number / Convert.ToInt32(Math.Pow(10, (degree10)));
// //     Console.WriteLine($"{firstOfNumber}");
// //     if (lastOfNumber != firstOfNumber)
// //     {
// //         Console.WriteLine("Введенное число не является полиндромом");
// //         break;
// //     }
// //     else
// //     {
// //         double numberNext = Convert.ToDouble(number % Convert.ToInt32(Math.Pow(10, (degree10))));
// //         number = Convert.ToInt32(numberNext) / 10;
// //         Console.WriteLine($"{number}");
// //     }
// //     degree10 = degree10 - 2;
// // }






