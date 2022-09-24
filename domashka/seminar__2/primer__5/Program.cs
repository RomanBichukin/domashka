//Напишите программу, которая принимает на вход два числа и проверяет,
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