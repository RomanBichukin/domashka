//Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//      0, 7, 8, -2, -2 -> 2
//      1, -7, 567, 89, 223-> 3
Console.Clear();

/*  Console.Write("Введите колличество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
        count++;
}
Console.WriteLine($"Положительных чисел: {count}"); */
//==================================================================================================
//==================================================================================================
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
 //k1 * x + b1 = k2 * x + b2
 // x(k1 - k2) = b2 - b1
 //     x = (b2-b1) / (k1 - k2)
 //
int x = (b2-b1) / (k1 - k2);
int y = k1 * x + b1;
Console.WriteLine($"Пересечение в точке: ({x};{y})");
