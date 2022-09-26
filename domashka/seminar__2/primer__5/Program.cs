/* //Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
//      5, 25 -> да
//      -4, 16 -> да
//      25, 5 -> да
//      8,9 -> нет
Console.Clear();
Console.WriteLine("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b*b | b == a*a)
{
    Console.WriteLine($"{a}, {b} -> YES");
}
else
{
    Console.WriteLine($"{a}, {b} -> NO");
}
============================================================================= 
-----------------------------------------------------------------------------
============================================================================= */
//Напиши программу, где вводим три числа, а потом выводим сумму только положительных чисел.

Console.Clear();
Console.WriteLine("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число: ");
int c = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (a < 0)
{
    a = 0;
    if (b < 0)
    {
        b = 0;
        if (c < 0)
        {
            c = 0;
        }
    }
}
result = a + b + c;

Console.WriteLine(result);


