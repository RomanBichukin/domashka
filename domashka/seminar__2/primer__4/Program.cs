﻿//Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
//      14 -> нет
//      46 -> нет
//      161 -> да
Console.Clear();

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int b = a%7;
int c = a%23;

if(b == 0 | c == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}