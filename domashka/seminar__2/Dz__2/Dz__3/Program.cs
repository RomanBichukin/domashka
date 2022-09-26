/* Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.

    6 -> да
    7 -> да
    1 -> нет */

Console.Clear();
Console.WriteLine("Введите чмсло от 1 до 7(включительно): ");
int A = Convert.ToInt32(Console.ReadLine());
if (A == 6 | A == 7)
{
    Console.WriteLine($"{A} -> ДА");
}
else
{
    Console.WriteLine($"{A} -> НЕТ");
}

