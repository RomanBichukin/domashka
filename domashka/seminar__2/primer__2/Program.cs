// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.
//      456 -> 46
//      782 -> 72
//      918 -> 98
Console.Clear();
int x = new Random().Next(100, 1000);
Console.WriteLine(x);

int b = x%10;
int a = (x/100) * 10;

Console.WriteLine(a+b);