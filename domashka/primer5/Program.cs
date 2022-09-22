//  Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает последнюю цифру этого числа.
//  456 -> 6
//  782 -> 2
//  918 -> 8

Console.Clear();
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int result = A % 10;
Console.Write($"Результат: {result}");
